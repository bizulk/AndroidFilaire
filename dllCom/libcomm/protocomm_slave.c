/// Définit une API haut-niveau **côté slave** pour communiquer en utilisant ce protocole.
/// L'objectif est de :
///     \arg finaliser l'implementation de la spec protocole : Echanges à réaliser pour répondre aux requêtes du master et les traiter
///     \arg fournir un exemple d'implémentation
///
/// Pour tout autre implémentation slave utiliser protocomm_ll.h
/// Cette implémentation montr

#include <assert.h>
#include "protocomm_slave.h"

proto_hdle_t * proto_slave_create(proto_Device_t iodevice, proto_OnReception_t callback, void* userdata)
{
    // Creation du protocole avec notre device
    proto_hdle_t * this = proto_create(iodevice);
    // En principe la création fonctionne, sinon le paramétrage sys est mauvais.
    assert(this);
    proto_setReceiver(this, callback, userdata);
    return this;
}

void proto_slave_destroy(proto_hdle_t * this)
{
    return proto_destroy(this);
}

int proto_slave_open(proto_hdle_t * this, const char * szPath)
{
    return proto_open(this, szPath);
}


int proto_slave_close(proto_hdle_t * this)
{
    return proto_close(this);
}

int proto_slave_main(proto_hdle_t * this)
{
    proto_Command_t cmd = 0;
    proto_Command_t cmdret = 0;
    proto_frame_data_t req = {.raw = {0}};
    int ret = -1;

    switch( proto_readFrame(this, PROTO_WAIT_FOREVER) )
    {
    case proto_NO_ERROR:
        switch( proto_decodeFrame(this, &cmd, &req))
        {
        case proto_COMPLETED:
            // Appeler la callaback
            if( this->priv_callback(this->priv_userdata, cmd, &req) == 0 )
            {
                cmdret = proto_CMD_REPLY;
                ret = 1;
            }
            else
            {
                cmdret = proto_CMD_ERR_ARG;
                ret = 1;
            }
            proto_writeFrame(this, cmdret, &req);
            break;
            case proto_WAITING:
            // Normalement on tombe pas dans ce cas, mais sait-on jamais
            ret = 0;
            break;
        case proto_REFUSED:
            // Erreur dans le décodage de la trame : renvoyer la réponse
            proto_writeFrame(this, cmd, &req);
            ret = 1;
            break;
        default:
            // Erreur dans les traitements
            assert(0);
            break;
        }
        break;
    case proto_ERR_SYS:
        ret = -1;
        break;
    case proto_TIMEOUT:
        ret = 0;
        break;
    default:
        ret = -1;
        break;
    }
    return ret;
}
