/**
 * GetTableResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTableResponse  implements java.io.Serializable {
    private org.tempuri.GetTableResponseGetTableResult getTableResult;

    public GetTableResponse() {
    }

    public GetTableResponse(
           org.tempuri.GetTableResponseGetTableResult getTableResult) {
           this.getTableResult = getTableResult;
    }


    /**
     * Gets the getTableResult value for this GetTableResponse.
     * 
     * @return getTableResult
     */
    public org.tempuri.GetTableResponseGetTableResult getGetTableResult() {
        return getTableResult;
    }


    /**
     * Sets the getTableResult value for this GetTableResponse.
     * 
     * @param getTableResult
     */
    public void setGetTableResult(org.tempuri.GetTableResponseGetTableResult getTableResult) {
        this.getTableResult = getTableResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTableResponse)) return false;
        GetTableResponse other = (GetTableResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTableResult==null && other.getGetTableResult()==null) || 
             (this.getTableResult!=null &&
              this.getTableResult.equals(other.getGetTableResult())));
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
        if (getGetTableResult() != null) {
            _hashCode += getGetTableResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetTableResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTableResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTableResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTableResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetTableResponse>GetTableResult"));
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
