/**
 * GetTableValuesAsListResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTableValuesAsListResponse  implements java.io.Serializable {
    private java.lang.Object[][] getTableValuesAsListResult;

    public GetTableValuesAsListResponse() {
    }

    public GetTableValuesAsListResponse(
           java.lang.Object[][] getTableValuesAsListResult) {
           this.getTableValuesAsListResult = getTableValuesAsListResult;
    }


    /**
     * Gets the getTableValuesAsListResult value for this GetTableValuesAsListResponse.
     * 
     * @return getTableValuesAsListResult
     */
    public java.lang.Object[][] getGetTableValuesAsListResult() {
        return getTableValuesAsListResult;
    }


    /**
     * Sets the getTableValuesAsListResult value for this GetTableValuesAsListResponse.
     * 
     * @param getTableValuesAsListResult
     */
    public void setGetTableValuesAsListResult(java.lang.Object[][] getTableValuesAsListResult) {
        this.getTableValuesAsListResult = getTableValuesAsListResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTableValuesAsListResponse)) return false;
        GetTableValuesAsListResponse other = (GetTableValuesAsListResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTableValuesAsListResult==null && other.getGetTableValuesAsListResult()==null) || 
             (this.getTableValuesAsListResult!=null &&
              java.util.Arrays.equals(this.getTableValuesAsListResult, other.getGetTableValuesAsListResult())));
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
        if (getGetTableValuesAsListResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetTableValuesAsListResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetTableValuesAsListResult(), i);
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
        new org.apache.axis.description.TypeDesc(GetTableValuesAsListResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTableValuesAsListResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTableValuesAsListResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTableValuesAsListResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "ArrayOfAnyType"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://tempuri.org/", "ArrayOfAnyType"));
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
