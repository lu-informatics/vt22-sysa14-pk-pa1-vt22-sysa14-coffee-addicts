/**
 * GetEmployeeRelativesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeeRelativesResponse  implements java.io.Serializable {
    private org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getEmployeeRelativesResult;

    public GetEmployeeRelativesResponse() {
    }

    public GetEmployeeRelativesResponse(
           org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getEmployeeRelativesResult) {
           this.getEmployeeRelativesResult = getEmployeeRelativesResult;
    }


    /**
     * Gets the getEmployeeRelativesResult value for this GetEmployeeRelativesResponse.
     * 
     * @return getEmployeeRelativesResult
     */
    public org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getGetEmployeeRelativesResult() {
        return getEmployeeRelativesResult;
    }


    /**
     * Sets the getEmployeeRelativesResult value for this GetEmployeeRelativesResponse.
     * 
     * @param getEmployeeRelativesResult
     */
    public void setGetEmployeeRelativesResult(org.tempuri.CRONUS_Sverige_AB_Employee_Relative[] getEmployeeRelativesResult) {
        this.getEmployeeRelativesResult = getEmployeeRelativesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeeRelativesResponse)) return false;
        GetEmployeeRelativesResponse other = (GetEmployeeRelativesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeeRelativesResult==null && other.getGetEmployeeRelativesResult()==null) || 
             (this.getEmployeeRelativesResult!=null &&
              java.util.Arrays.equals(this.getEmployeeRelativesResult, other.getGetEmployeeRelativesResult())));
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
        if (getGetEmployeeRelativesResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetEmployeeRelativesResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetEmployeeRelativesResult(), i);
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
        new org.apache.axis.description.TypeDesc(GetEmployeeRelativesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeeRelativesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeeRelativesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeeRelativesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Relative"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Relative"));
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
