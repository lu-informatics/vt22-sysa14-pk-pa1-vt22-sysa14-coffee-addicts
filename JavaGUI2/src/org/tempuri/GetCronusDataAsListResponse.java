/**
 * GetCronusDataAsListResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetCronusDataAsListResponse  implements java.io.Serializable {
    private java.lang.Object[][] getCronusDataAsListResult;

    public GetCronusDataAsListResponse() {
    }

    public GetCronusDataAsListResponse(
           java.lang.Object[][] getCronusDataAsListResult) {
           this.getCronusDataAsListResult = getCronusDataAsListResult;
    }


    /**
     * Gets the getCronusDataAsListResult value for this GetCronusDataAsListResponse.
     * 
     * @return getCronusDataAsListResult
     */
    public java.lang.Object[][] getGetCronusDataAsListResult() {
        return getCronusDataAsListResult;
    }


    /**
     * Sets the getCronusDataAsListResult value for this GetCronusDataAsListResponse.
     * 
     * @param getCronusDataAsListResult
     */
    public void setGetCronusDataAsListResult(java.lang.Object[][] getCronusDataAsListResult) {
        this.getCronusDataAsListResult = getCronusDataAsListResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetCronusDataAsListResponse)) return false;
        GetCronusDataAsListResponse other = (GetCronusDataAsListResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getCronusDataAsListResult==null && other.getGetCronusDataAsListResult()==null) || 
             (this.getCronusDataAsListResult!=null &&
              java.util.Arrays.equals(this.getCronusDataAsListResult, other.getGetCronusDataAsListResult())));
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
        if (getGetCronusDataAsListResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetCronusDataAsListResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetCronusDataAsListResult(), i);
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
        new org.apache.axis.description.TypeDesc(GetCronusDataAsListResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetCronusDataAsListResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getCronusDataAsListResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetCronusDataAsListResult"));
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
