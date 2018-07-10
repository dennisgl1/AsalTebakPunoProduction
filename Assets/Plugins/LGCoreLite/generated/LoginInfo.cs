//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace LGCoreLite {

public class LoginInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LoginInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LoginInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LoginInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LGCoreLitePINVOKE.delete_LoginInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static LoginInfo buildLoginInfo(LoginInfo.LoginType loginType, string loginID) {
    LoginInfo ret = new LoginInfo(LGCoreLitePINVOKE.LoginInfo_buildLoginInfo((int)loginType, loginID), true);
    if (LGCoreLitePINVOKE.SWIGPendingException.Pending) throw LGCoreLitePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static LoginInfo buildGuestLoginInfo(string loginID) {
    LoginInfo ret = new LoginInfo(LGCoreLitePINVOKE.LoginInfo_buildGuestLoginInfo(loginID), true);
    if (LGCoreLitePINVOKE.SWIGPendingException.Pending) throw LGCoreLitePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static LoginInfo buildLineLoginInfo() {
    LoginInfo ret = new LoginInfo(LGCoreLitePINVOKE.LoginInfo_buildLineLoginInfo(), true);
    return ret;
  }

  public LoginInfo() : this(LGCoreLitePINVOKE.new_LoginInfo__SWIG_0(), true) {
  }

  public LoginInfo(LoginInfo.LoginType type, string loginID) : this(LGCoreLitePINVOKE.new_LoginInfo__SWIG_1((int)type, loginID), true) {
    if (LGCoreLitePINVOKE.SWIGPendingException.Pending) throw LGCoreLitePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGuestLogin(string loginID) {
    LGCoreLitePINVOKE.LoginInfo_setGuestLogin(swigCPtr, loginID);
    if (LGCoreLitePINVOKE.SWIGPendingException.Pending) throw LGCoreLitePINVOKE.SWIGPendingException.Retrieve();
  }

  public LoginInfo.LoginType getLoginType() {
    LoginInfo.LoginType ret = (LoginInfo.LoginType)LGCoreLitePINVOKE.LoginInfo_getLoginType(swigCPtr);
    return ret;
  }

  public enum LoginType {
    LGCLineLogin = 0,

    LGCGuestLogin = 1,
    LGFacebookLogin = 4,
    LGNaverLogin = 5,
    LGGameCenterLogin = 6,
    LGGoogleLogin = 7
  }

}

}