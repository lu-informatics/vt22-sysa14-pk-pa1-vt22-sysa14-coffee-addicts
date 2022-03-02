package org.tempuri;

public class WebService1SoapProxy implements org.tempuri.WebService1Soap {
  private String _endpoint = null;
  private org.tempuri.WebService1Soap webService1Soap = null;
  
  public WebService1SoapProxy() {
    _initWebService1SoapProxy();
  }
  
  public WebService1SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebService1SoapProxy();
  }
  
  private void _initWebService1SoapProxy() {
    try {
      webService1Soap = (new org.tempuri.WebService1Locator()).getWebService1Soap();
      if (webService1Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webService1Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webService1Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webService1Soap != null)
      ((javax.xml.rpc.Stub)webService1Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebService1Soap getWebService1Soap() {
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap;
  }
  
  public java.lang.String findFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.findFile(fileName);
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.helloWorld();
  }
  
  public org.tempuri.GetTableResponseGetTableResult getTable(java.lang.String tableName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getTable(tableName);
  }
  
  public org.tempuri.GetTableNamesResponseGetTableNamesResult getTableNames() throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getTableNames();
  }
  
  public java.lang.Object[][] getTableValuesAsList(java.lang.String tableName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getTableValuesAsList(tableName);
  }
  
  public java.lang.Object[][] getColumnNamesAsList(java.lang.String tableName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getColumnNamesAsList(tableName);
  }
  
  public void createEmployee(org.tempuri.CRONUS_Sverige_AB_Employee employee) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    webService1Soap.createEmployee(employee);
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployees() throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getEmployees();
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee_Absence[] getEmployeeAbsence(java.lang.String primaryKey) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getEmployeeAbsence(primaryKey);
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getEmployeeRelatives(java.lang.String primaryKey) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getEmployeeRelatives(primaryKey);
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getEmployeeQualifications(java.lang.String primaryKey) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getEmployeeQualifications(primaryKey);
  }
  
  public void deleteEmployee(java.lang.String pk) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    webService1Soap.deleteEmployee(pk);
  }
  
  public void updateEmployee(org.tempuri.CRONUS_Sverige_AB_Employee employee) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    webService1Soap.updateEmployee(employee);
  }
  
  public org.tempuri.GetCronusDataResponseGetCronusDataResult getCronusData(java.lang.String methodName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getCronusData(methodName);
  }
  
  public java.lang.Object[][] getCronusDataAsList(java.lang.String methodName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getCronusDataAsList(methodName);
  }
  
  public java.lang.String[] getCronusHeaders(java.lang.String methodName) throws java.rmi.RemoteException{
    if (webService1Soap == null)
      _initWebService1SoapProxy();
    return webService1Soap.getCronusHeaders(methodName);
  }
  
  
}