/**
 * GetEmployeeQualificationsResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeeQualificationsResponse  implements java.io.Serializable {
    private org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getEmployeeQualificationsResult;

    public GetEmployeeQualificationsResponse() {
    }

    public GetEmployeeQualificationsResponse(
           org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getEmployeeQualificationsResult) {
           this.getEmployeeQualificationsResult = getEmployeeQualificationsResult;
    }


    /**
     * Gets the getEmployeeQualificationsResult value for this GetEmployeeQualificationsResponse.
     * 
     * @return getEmployeeQualificationsResult
     */
    public org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getGetEmployeeQualificationsResult() {
        return getEmployeeQualificationsResult;
    }


    /**
     * Sets the getEmployeeQualificationsResult value for this GetEmployeeQualificationsResponse.
     * 
     * @param getEmployeeQualificationsResult
     */
    public void setGetEmployeeQualificationsResult(org.tempuri.CRONUS_Sverige_AB_Employee_Qualification[] getEmployeeQualificationsResult) {
        this.getEmployeeQualificationsResult = getEmployeeQualificationsResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeeQualificationsResponse)) return false;
        GetEmployeeQualificationsResponse other = (GetEmployeeQualificationsResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeeQualificationsResult==null && other.getGetEmployeeQualificationsResult()==null) || 
             (this.getEmployeeQualificationsResult!=null &&
              java.util.Arrays.equals(this.getEmployeeQualificationsResult, other.getGetEmployeeQualificationsResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetEmployeeQualificationsResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetEmployeeQualificationsResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetEmployeeQualificationsResult(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetEmployeeQualificationsResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeeQualificationsResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeeQualificationsResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeeQualificationsResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Qualification"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Qualification"));
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
