/**
 * GetTableNamesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTableNamesResponse  implements java.io.Serializable {
    private org.tempuri.GetTableNamesResponseGetTableNamesResult getTableNamesResult;

    public GetTableNamesResponse() {
    }

    public GetTableNamesResponse(
           org.tempuri.GetTableNamesResponseGetTableNamesResult getTableNamesResult) {
           this.getTableNamesResult = getTableNamesResult;
    }


    /**
     * Gets the getTableNamesResult value for this GetTableNamesResponse.
     * 
     * @return getTableNamesResult
     */
    public org.tempuri.GetTableNamesResponseGetTableNamesResult getGetTableNamesResult() {
        return getTableNamesResult;
    }


    /**
     * Sets the getTableNamesResult value for this GetTableNamesResponse.
     * 
     * @param getTableNamesResult
     */
    public void setGetTableNamesResult(org.tempuri.GetTableNamesResponseGetTableNamesResult getTableNamesResult) {
        this.getTableNamesResult = getTableNamesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTableNamesResponse)) return false;
        GetTableNamesResponse other = (GetTableNamesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTableNamesResult==null && other.getGetTableNamesResult()==null) || 
             (this.getTableNamesResult!=null &&
              this.getTableNamesResult.equals(other.getGetTableNamesResult())));
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
        if (getGetTableNamesResult() != null) {
            _hashCode += getGetTableNamesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetTableNamesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTableNamesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTableNamesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTableNamesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetTableNamesResponse>GetTableNamesResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
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
