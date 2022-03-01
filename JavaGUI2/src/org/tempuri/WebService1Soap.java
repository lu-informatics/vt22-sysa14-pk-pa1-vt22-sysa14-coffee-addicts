/**
 * WebService1Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface WebService1Soap extends java.rmi.Remote {
    public java.lang.String helloWorld() throws java.rmi.RemoteException;
    public org.tempuri.GetTableResponseGetTableResult getTable(java.lang.String tableName) throws java.rmi.RemoteException;
    public org.tempuri.GetTableNamesResponseGetTableNamesResult getTableNames() throws java.rmi.RemoteException;
    public java.lang.Object[][] getTableValuesAsList(java.lang.String tableName) throws java.rmi.RemoteException;
    public java.lang.Object[][] getColumnNamesAsList(java.lang.String tableName) throws java.rmi.RemoteException;
    public void createEmployee(org.tempuri.CRONUS_Sverige_AB_Employee employee) throws java.rmi.RemoteException;
    public org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployees() throws java.rmi.RemoteException;
    public org.tempuri.CRONUS_Sverige_AB_Employee_Absence[] getEmployeeAbsence(java.lang.String primaryKey) throws java.rmi.RemoteException;
    public org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getEmployeeRelatives(java.lang.String primaryKey) throws java.rmi.RemoteException;
    public org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getEmployeeQualifications(java.lang.String primaryKey) throws java.rmi.RemoteException;
    public void deleteEmployee(java.lang.String pk) throws java.rmi.RemoteException;
    public void updateEmployee(org.tempuri.CRONUS_Sverige_AB_Employee employee) throws java.rmi.RemoteException;
    public org.tempuri.GetCronusDataResponseGetCronusDataResult getCronusData(java.lang.String methodName) throws java.rmi.RemoteException;
    public java.lang.Object[][] getCronusDataAsList(java.lang.String methodName) throws java.rmi.RemoteException;
    public java.lang.String[] getCronusHeaders(java.lang.String methodName) throws java.rmi.RemoteException;
}
