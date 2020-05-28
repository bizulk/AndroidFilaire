//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class protocomm {
  public static SWIGTYPE_p_unsigned_char new_uint8_t_p() {
    global::System.IntPtr cPtr = protocommPINVOKE.new_uint8_t_p();
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_unsigned_char copy_uint8_t_p(byte value) {
    global::System.IntPtr cPtr = protocommPINVOKE.copy_uint8_t_p(value);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public static void delete_uint8_t_p(SWIGTYPE_p_unsigned_char obj) {
    protocommPINVOKE.delete_uint8_t_p(SWIGTYPE_p_unsigned_char.getCPtr(obj));
  }

  public static void uint8_t_p_assign(SWIGTYPE_p_unsigned_char obj, byte value) {
    protocommPINVOKE.uint8_t_p_assign(SWIGTYPE_p_unsigned_char.getCPtr(obj), value);
  }

  public static byte uint8_t_p_value(SWIGTYPE_p_unsigned_char obj) {
    byte ret = protocommPINVOKE.uint8_t_p_value(SWIGTYPE_p_unsigned_char.getCPtr(obj));
    return ret;
  }

  public static proto_hdle_t proto_cio_open(string szDev) {
    global::System.IntPtr cPtr = protocommPINVOKE.proto_cio_open(szDev);
    proto_hdle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new proto_hdle_t(cPtr, false);
    return ret;
  }

  public static proto_hdle_t proto_master_create(SWIGTYPE_p_proto_Device_t iodevice) {
    global::System.IntPtr cPtr = protocommPINVOKE.proto_master_create(SWIGTYPE_p_proto_Device_t.getCPtr(iodevice));
    proto_hdle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new proto_hdle_t(cPtr, false);
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void proto_master_destroy(proto_hdle_t _this) {
    protocommPINVOKE.proto_master_destroy(proto_hdle_t.getCPtr(_this));
  }

  public static int proto_master_open(proto_hdle_t _this, string szPath) {
    int ret = protocommPINVOKE.proto_master_open(proto_hdle_t.getCPtr(_this), szPath);
    return ret;
  }

  public static int proto_master_close(proto_hdle_t _this) {
    int ret = protocommPINVOKE.proto_master_close(proto_hdle_t.getCPtr(_this));
    return ret;
  }

  public static proto_Status_t proto_master_get(proto_hdle_t _this, byte register_, SWIGTYPE_p_unsigned_char value) {
    proto_Status_t ret = (proto_Status_t)protocommPINVOKE.proto_master_get(proto_hdle_t.getCPtr(_this), register_, SWIGTYPE_p_unsigned_char.getCPtr(value));
    return ret;
  }

  public static proto_Status_t proto_master_set(proto_hdle_t _this, byte register_, byte value) {
    proto_Status_t ret = (proto_Status_t)protocommPINVOKE.proto_master_set(proto_hdle_t.getCPtr(_this), register_, value);
    return ret;
  }

  public static proto_hdle_t proto_create(SWIGTYPE_p_proto_Device_t iodevice) {
    global::System.IntPtr cPtr = protocommPINVOKE.proto_create(SWIGTYPE_p_proto_Device_t.getCPtr(iodevice));
    proto_hdle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new proto_hdle_t(cPtr, false);
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void proto_init(proto_hdle_t _this, SWIGTYPE_p_proto_Device_t iodevice) {
    protocommPINVOKE.proto_init(proto_hdle_t.getCPtr(_this), SWIGTYPE_p_proto_Device_t.getCPtr(iodevice));
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void proto_destroy(proto_hdle_t _this) {
    protocommPINVOKE.proto_destroy(proto_hdle_t.getCPtr(_this));
  }

  public static int proto_open(proto_hdle_t _this, string szPath) {
    int ret = protocommPINVOKE.proto_open(proto_hdle_t.getCPtr(_this), szPath);
    return ret;
  }

  public static int proto_close(proto_hdle_t _this) {
    int ret = protocommPINVOKE.proto_close(proto_hdle_t.getCPtr(_this));
    return ret;
  }

  public static proto_Status_t proto_readFrame(proto_hdle_t _this, short tout_ms) {
    proto_Status_t ret = (proto_Status_t)protocommPINVOKE.proto_readFrame(proto_hdle_t.getCPtr(_this), tout_ms);
    return ret;
  }

  public static proto_DecodeStatus_t proto_decodeFrame(proto_hdle_t _this, SWIGTYPE_p_proto_Command cmd, proto_frame_data_t arg) {
    proto_DecodeStatus_t ret = (proto_DecodeStatus_t)protocommPINVOKE.proto_decodeFrame(proto_hdle_t.getCPtr(_this), SWIGTYPE_p_proto_Command.getCPtr(cmd), proto_frame_data_t.getCPtr(arg));
    return ret;
  }

  public static int proto_writeFrame(proto_hdle_t _this, proto_Command_t command, proto_frame_data_t args) {
    int ret = protocommPINVOKE.proto_writeFrame(proto_hdle_t.getCPtr(_this), (int)command, proto_frame_data_t.getCPtr(args));
    return ret;
  }

  public static byte proto_getArgsSize(proto_Command_t cmd) {
    byte ret = protocommPINVOKE.proto_getArgsSize((int)cmd);
    return ret;
  }

  public static void proto_setReceiver(proto_hdle_t _this, SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int callback, SWIGTYPE_p_void userdata) {
    protocommPINVOKE.proto_setReceiver(proto_hdle_t.getCPtr(_this), SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int.getCPtr(callback), SWIGTYPE_p_void.getCPtr(userdata));
  }

  public static int proto_pushToFrame(proto_hdle_t _this, SWIGTYPE_p_unsigned_char buf, uint len) {
    int ret = protocommPINVOKE.proto_pushToFrame(proto_hdle_t.getCPtr(_this), SWIGTYPE_p_unsigned_char.getCPtr(buf), len);
    return ret;
  }

  public static byte proto_makeFrame(proto_Frame_t frame, proto_Command_t command, proto_frame_data_t args) {
    byte ret = protocommPINVOKE.proto_makeFrame(proto_Frame_t.getCPtr(frame), (int)command, proto_frame_data_t.getCPtr(args));
    return ret;
  }

  public static SWIGTYPE_p_proto_Device_t devemulslave_create() {
    SWIGTYPE_p_proto_Device_t ret = new SWIGTYPE_p_proto_Device_t(protocommPINVOKE.devemulslave_create(), true);
    return ret;
  }

  public static SWIGTYPE_p_unsigned_char devemulslave_getRegisters(SWIGTYPE_p_proto_Device_t _this) {
    global::System.IntPtr cPtr = protocommPINVOKE.devemulslave_getRegisters(SWIGTYPE_p_proto_Device_t.getCPtr(_this));
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void devemulslave_setFlags(SWIGTYPE_p_proto_Device_t _this, byte FLAGS) {
    protocommPINVOKE.devemulslave_setFlags(SWIGTYPE_p_proto_Device_t.getCPtr(_this), FLAGS);
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void devemulslave_getFlags(SWIGTYPE_p_proto_Device_t _this, SWIGTYPE_p_unsigned_char FLAGS) {
    protocommPINVOKE.devemulslave_getFlags(SWIGTYPE_p_proto_Device_t.getCPtr(_this), SWIGTYPE_p_unsigned_char.getCPtr(FLAGS));
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SWIGTYPE_p_proto_Device_t devserial_create() {
    SWIGTYPE_p_proto_Device_t ret = new SWIGTYPE_p_proto_Device_t(protocommPINVOKE.devserial_create(), true);
    return ret;
  }

  public static int devserial_setFD(SWIGTYPE_p_proto_Device_t _this, int fileDescriptor) {
    int ret = protocommPINVOKE.devserial_setFD(SWIGTYPE_p_proto_Device_t.getCPtr(_this), fileDescriptor);
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int devserial_getFD(SWIGTYPE_p_proto_Device_t _this) {
    int ret = protocommPINVOKE.devserial_getFD(SWIGTYPE_p_proto_Device_t.getCPtr(_this));
    if (protocommPINVOKE.SWIGPendingException.Pending) throw protocommPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly int PROTO_FRAME_RECV_TOUT_MS = protocommPINVOKE.PROTO_FRAME_RECV_TOUT_MS_get();
  public static readonly int proto_START_OF_FRAME = protocommPINVOKE.proto_START_OF_FRAME_get();
  public static readonly int proto_COMMAND_OFFSET = protocommPINVOKE.proto_COMMAND_OFFSET_get();
  public static readonly int proto_ARGS_OFFSET = protocommPINVOKE.proto_ARGS_OFFSET_get();
  public static readonly int proto_FRAME_MAXSIZE = protocommPINVOKE.proto_FRAME_MAXSIZE_get();

  public static readonly int PROTO_WAIT_FOREVER = protocommPINVOKE.PROTO_WAIT_FOREVER_get();
  public static readonly int EMULSLAVE_NB_REGS = protocommPINVOKE.EMULSLAVE_NB_REGS_get();
}
