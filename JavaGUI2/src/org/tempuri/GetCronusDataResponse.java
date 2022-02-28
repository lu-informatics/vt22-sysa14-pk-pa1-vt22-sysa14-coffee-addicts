/**
 * GetCronusDataResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetCronusDataResponse  implements java.io.Serializable {
    private org.tempuri.GetCronusDataResponseGetCronusDataResult getCronusDataResult;

    public GetCronusDataResponse() {
    }

    public GetCronusDataResponse(
           org.tempuri.GetCronusDataResponseGetCronusDataResult getCronusDataResult) {
           this.getCronusDataResult = getCronusDataResult;
    }


    /**
     * Gets the getCronusDataResult value for this GetCronusDataResponse.
     * 
     * @return getCronusDataResult
     */
    public org.tempuri.GetCronusDataResponseGetCronusDataResult getGetCronusDataResult() {
        return getCronusDataResult;
    }


    /**
     * Sets the getCronusDataResult value for this GetCronusDataResponse.
     * 
     * @param getCronusDataResult
     */
    public void setGetCronusDataResult(org.tempuri.GetCronusDataResponseGetCronusDataResult getCronusDataResult) {
        this.getCronusDataResult = getCronusDataResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetCronusDataResponse)) return false;
        GetCronusDataResponse other = (GetCronusDataResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getCronusDataResult==null && other.getGetCronusDataResult()==null) || 
             (this.getCronusDataResult!=null &&
              this.getCronusDataResult.equals(other.getGetCronusDataResult())));
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
        if (getGetCronusDataResult() != null) {
            _hashCode += getGetCronusDataResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetCronusDataResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetCronusDataResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getCronusDataResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetCronusDataResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetCronusDataResponse>GetCronusDataResult"));
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
