package org.tempuri;

public class ServoSoapProxy implements org.tempuri.ServoSoap {
  private String _endpoint = null;
  private org.tempuri.ServoSoap servoSoap = null;
  
  public ServoSoapProxy() {
    _initServoSoapProxy();
  }
  
  public ServoSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initServoSoapProxy();
  }
  
  private void _initServoSoapProxy() {
    try {
      servoSoap = (new org.tempuri.ServoLocator()).getServoSoap();
      if (servoSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)servoSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)servoSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (servoSoap != null)
      ((javax.xml.rpc.Stub)servoSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.ServoSoap getServoSoap() {
    if (servoSoap == null)
      _initServoSoapProxy();
    return servoSoap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (servoSoap == null)
      _initServoSoapProxy();
    return servoSoap.helloWorld();
  }
  
  public java.lang.String findFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (servoSoap == null)
      _initServoSoapProxy();
    return servoSoap.findFile(fileName);
  }
  
  public void getTable() throws java.rmi.RemoteException{
    if (servoSoap == null)
      _initServoSoapProxy();
    servoSoap.getTable();
  }
  
  
}