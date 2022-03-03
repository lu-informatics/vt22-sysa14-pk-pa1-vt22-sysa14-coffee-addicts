/**
 * GetEmployeesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeesResponse  implements java.io.Serializable {
    private org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployeesResult;

    public GetEmployeesResponse() {
    }

    public GetEmployeesResponse(
           org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployeesResult) {
           this.getEmployeesResult = getEmployeesResult;
    }


    /**
     * Gets the getEmployeesResult value for this GetEmployeesResponse.
     * 
     * @return getEmployeesResult
     */
    public org.tempuri.CRONUS_Sverige_AB_Employee[] getGetEmployeesResult() {
        return getEmployeesResult;
    }


    /**
     * Sets the getEmployeesResult value for this GetEmployeesResponse.
     * 
     * @param getEmployeesResult
     */
    public void setGetEmployeesResult(org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployeesResult) {
        this.getEmployeesResult = getEmployeesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeesResponse)) return false;
        GetEmployeesResponse other = (GetEmployeesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeesResult==null && other.getGetEmployeesResult()==null) || 
             (this.getEmployeesResult!=null &&
              java.util.Arrays.equals(this.getEmployeesResult, other.getGetEmployeesResult())));
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
        if (getGetEmployeesResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetEmployeesResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetEmployeesResult(), i);
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
        new org.apache.axis.description.TypeDesc(GetEmployeesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee"));
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
