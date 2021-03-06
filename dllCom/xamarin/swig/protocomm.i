 /* example.i */
 %module protocomm
 %{
	#include "protocomm_master.h"
	#include "log.h"
	#include "devices/device_emulslave.h"
	#include "devices/device_serial.h"
	#include "devices/device_usbdev.h"
	#include "devices/device_libusb.h"
	#include "devices/device_proxy.h"
	#include "proto_iodevice.h"
	
	void protoframe_serialize(proto_Frame_t * pframe, uint8_t * buf )
	{ 
		/* No other way found than a memcpy */
		memcpy(buf, pframe, sizeof(*pframe));
	}
	devproxy_header_t * devproxy_cast( uint8_t * pcHeader)
	{
		return (devproxy_header_t *)pcHeader;
	}
 %}

 /* utiliser les fichiers d'interface pour les standard sinon on a des types opaques
https://stackoverflow.com/questions/10476483/how-to-generate-a-cross-platform-interface-with-swig
*/
%include "stdint.i"

/* cpointer creates helper for opaque pointer type that swig create 
*/
%include "cpointer.i"
/* The high level API do create an opaque type for uint8 pointer */
%pointer_functions(uint8_t, uint8_t_p);
/* When using protocomm low level, protocommand is taken as pointer and swig creates an opaque type. With this we can handle the type and its value*/
%pointer_functions(proto_Command_t, proto_Command_t_p);


/* BEGIN : some "magic" to apply buf as byte[] type instead of opaque type */
%include "arrays_csharp.i"
CSHARP_ARRAYS(char, byte)
/* we ask that all arument of that type and name shall be treated as */
%apply char INPUT[]  { uint8_t * buf }
/* END */
%include "libcomm_global.h"
%include "protocomm_master.h"
%include "protocomm_ll.h"
%include "device_emulslave.h"
%include "device_serial.h"
%include "device_usbdev.h"
%include "device_libusb.h"
%include "device_proxy.h" 
%include "log.h"
%include "proto_iodevice.h"

/* Extra function for helping to interact with the dll 
	pointer_cast does not work it converts char to string, not handled then. We make a specific data copy to byte buffer
*/
%apply char OUTPUT[]  { uint8_t * buf }
void protoframe_serialize(proto_Frame_t * pframe, uint8_t * buf );

/* Device Proxy  
	We'll need the byte type for the socket call, and decode them for intepreting the frame header
	To avoid memorycpoy overhead we set a cast 
*/
%apply char INPUT[]  { uint8_t * pcHeader }
devproxy_header_t * devproxy_cast( uint8_t * pcHeader);
/* END */
%include "sizeof.i"
%_sizeof(proto_Frame_t)
%_sizeof(devproxy_header_t)
