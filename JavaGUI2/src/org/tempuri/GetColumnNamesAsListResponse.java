/**
 * GetColumnNamesAsListResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetColumnNamesAsListResponse  implements java.io.Serializable {
    private java.lang.Object[][] getColumnNamesAsListResult;

    public GetColumnNamesAsListResponse() {
    }

    public GetColumnNamesAsListResponse(
           java.lang.Object[][] getColumnNamesAsListResult) {
           this.getColumnNamesAsListResult = getColumnNamesAsListResult;
    }


    /**
     * Gets the getColumnNamesAsListResult value for this GetColumnNamesAsListResponse.
     * 
     * @return getColumnNamesAsListResult
     */
    public java.lang.Object[][] getGetColumnNamesAsListResult() {
        return getColumnNamesAsListResult;
    }


    /**
     * Sets the getColumnNamesAsListResult value for this GetColumnNamesAsListResponse.
     * 
     * @param getColumnNamesAsListResult
     */
    public void setGetColumnNamesAsListResult(java.lang.Object[][] getColumnNamesAsListResult) {
        this.getColumnNamesAsListResult = getColumnNamesAsListResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetColumnNamesAsListResponse)) return false;
        GetColumnNamesAsListResponse other = (GetColumnNamesAsListResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getColumnNamesAsListResult==null && other.getGetColumnNamesAsListResult()==null) || 
             (this.getColumnNamesAsListResult!=null &&
              java.util.Arrays.equals(this.getColumnNamesAsListResult, other.getGetColumnNamesAsListResult())));
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
        if (getGetColumnNamesAsListResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetColumnNamesAsListResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetColumnNamesAsListResult(), i);
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
        new org.apache.axis.description.TypeDesc(GetColumnNamesAsListResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetColumnNamesAsListResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getColumnNamesAsListResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetColumnNamesAsListResult"));
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
