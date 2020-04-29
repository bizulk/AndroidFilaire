#ifndef CIO_TSE_PROTOCOMM_EMULSLAVE
#define CIO_TSE_PROTOCOMM_EMULSLAVE

#include "protocomm.h"

#ifdef __cplusplus
extern "C" {
#endif

/// Structure de données utiles pour l'émulation de l'esclave.
/// Les attributs préfixés priv_ ne doivent pas être accédés
/// (violation de l'encapsulation).
typedef struct proto_Data_EmulSlave {
	uint8_t registers[20]; ///< Les registres qui seront récupérés et modifiés
	proto_State priv_state;
	uint8_t priv_delayedBytes[8 * proto_FRAME_MAXSIZE];
	uint8_t priv_nbDelayedBytes;
} proto_Data_EmulSlave;

/// Pour initaliser les données du device d'émulation de l'esclave
void proto_initData_EmulSlave(proto_Data_EmulSlave* iodata);

/// Retourne le Device (= pointeur vers l'interface read/write). Le iodata à passer
/// dans les fonctions est un pointeur vers un proto_Data_EmulSlave.
proto_Device proto_getDevice_EmulSlave();

#ifdef __cplusplus
} // extern "C"
#endif

#endif
