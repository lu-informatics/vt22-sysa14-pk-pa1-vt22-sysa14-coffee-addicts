/**
 * CRONUS_Sverige_AB_Employee_Relative.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class CRONUS_Sverige_AB_Employee_Relative  implements java.io.Serializable {
    private byte[] timestamp;

    private java.lang.String employee_No_;

    private int line_No_;

    private java.lang.String relative_Code;

    private java.lang.String first_Name;

    private java.lang.String middle_Name;

    private java.lang.String last_Name;

    private java.util.Calendar birth_Date;

    private java.lang.String phone_No_;

    private java.lang.String relative_s_Employee_No_;

    public CRONUS_Sverige_AB_Employee_Relative() {
    }

    public CRONUS_Sverige_AB_Employee_Relative(
           byte[] timestamp,
           java.lang.String employee_No_,
           int line_No_,
           java.lang.String relative_Code,
           java.lang.String first_Name,
           java.lang.String middle_Name,
           java.lang.String last_Name,
           java.util.Calendar birth_Date,
           java.lang.String phone_No_,
           java.lang.String relative_s_Employee_No_) {
           this.timestamp = timestamp;
           this.employee_No_ = employee_No_;
           this.line_No_ = line_No_;
           this.relative_Code = relative_Code;
           this.first_Name = first_Name;
           this.middle_Name = middle_Name;
           this.last_Name = last_Name;
           this.birth_Date = birth_Date;
           this.phone_No_ = phone_No_;
           this.relative_s_Employee_No_ = relative_s_Employee_No_;
    }


    /**
     * Gets the timestamp value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return timestamp
     */
    public byte[] getTimestamp() {
        return timestamp;
    }


    /**
     * Sets the timestamp value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param timestamp
     */
    public void setTimestamp(byte[] timestamp) {
        this.timestamp = timestamp;
    }


    /**
     * Gets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return employee_No_
     */
    public java.lang.String getEmployee_No_() {
        return employee_No_;
    }


    /**
     * Sets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param employee_No_
     */
    public void setEmployee_No_(java.lang.String employee_No_) {
        this.employee_No_ = employee_No_;
    }


    /**
     * Gets the line_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return line_No_
     */
    public int getLine_No_() {
        return line_No_;
    }


    /**
     * Sets the line_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param line_No_
     */
    public void setLine_No_(int line_No_) {
        this.line_No_ = line_No_;
    }


    /**
     * Gets the relative_Code value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return relative_Code
     */
    public java.lang.String getRelative_Code() {
        return relative_Code;
    }


    /**
     * Sets the relative_Code value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param relative_Code
     */
    public void setRelative_Code(java.lang.String relative_Code) {
        this.relative_Code = relative_Code;
    }


    /**
     * Gets the first_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return first_Name
     */
    public java.lang.String getFirst_Name() {
        return first_Name;
    }


    /**
     * Sets the first_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param first_Name
     */
    public void setFirst_Name(java.lang.String first_Name) {
        this.first_Name = first_Name;
    }


    /**
     * Gets the middle_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return middle_Name
     */
    public java.lang.String getMiddle_Name() {
        return middle_Name;
    }


    /**
     * Sets the middle_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param middle_Name
     */
    public void setMiddle_Name(java.lang.String middle_Name) {
        this.middle_Name = middle_Name;
    }


    /**
     * Gets the last_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return last_Name
     */
    public java.lang.String getLast_Name() {
        return last_Name;
    }


    /**
     * Sets the last_Name value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param last_Name
     */
    public void setLast_Name(java.lang.String last_Name) {
        this.last_Name = last_Name;
    }


    /**
     * Gets the birth_Date value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return birth_Date
     */
    public java.util.Calendar getBirth_Date() {
        return birth_Date;
    }


    /**
     * Sets the birth_Date value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param birth_Date
     */
    public void setBirth_Date(java.util.Calendar birth_Date) {
        this.birth_Date = birth_Date;
    }


    /**
     * Gets the phone_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return phone_No_
     */
    public java.lang.String getPhone_No_() {
        return phone_No_;
    }


    /**
     * Sets the phone_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param phone_No_
     */
    public void setPhone_No_(java.lang.String phone_No_) {
        this.phone_No_ = phone_No_;
    }


    /**
     * Gets the relative_s_Employee_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @return relative_s_Employee_No_
     */
    public java.lang.String getRelative_s_Employee_No_() {
        return relative_s_Employee_No_;
    }


    /**
     * Sets the relative_s_Employee_No_ value for this CRONUS_Sverige_AB_Employee_Relative.
     * 
     * @param relative_s_Employee_No_
     */
    public void setRelative_s_Employee_No_(java.lang.String relative_s_Employee_No_) {
        this.relative_s_Employee_No_ = relative_s_Employee_No_;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof CRONUS_Sverige_AB_Employee_Relative)) return false;
        CRONUS_Sverige_AB_Employee_Relative other = (CRONUS_Sverige_AB_Employee_Relative) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.timestamp==null && other.getTimestamp()==null) || 
             (this.timestamp!=null &&
              java.util.Arrays.equals(this.timestamp, other.getTimestamp()))) &&
            ((this.employee_No_==null && other.getEmployee_No_()==null) || 
             (this.employee_No_!=null &&
              this.employee_No_.equals(other.getEmployee_No_()))) &&
            this.line_No_ == other.getLine_No_() &&
            ((this.relative_Code==null && other.getRelative_Code()==null) || 
             (this.relative_Code!=null &&
              this.relative_Code.equals(other.getRelative_Code()))) &&
            ((this.first_Name==null && other.getFirst_Name()==null) || 
             (this.first_Name!=null &&
              this.first_Name.equals(other.getFirst_Name()))) &&
            ((this.middle_Name==null && other.getMiddle_Name()==null) || 
             (this.middle_Name!=null &&
              this.middle_Name.equals(other.getMiddle_Name()))) &&
            ((this.last_Name==null && other.getLast_Name()==null) || 
             (this.last_Name!=null &&
              this.last_Name.equals(other.getLast_Name()))) &&
            ((this.birth_Date==null && other.getBirth_Date()==null) || 
             (this.birth_Date!=null &&
              this.birth_Date.equals(other.getBirth_Date()))) &&
            ((this.phone_No_==null && other.getPhone_No_()==null) || 
             (this.phone_No_!=null &&
              this.phone_No_.equals(other.getPhone_No_()))) &&
            ((this.relative_s_Employee_No_==null && other.getRelative_s_Employee_No_()==null) || 
             (this.relative_s_Employee_No_!=null &&
              this.relative_s_Employee_No_.equals(other.getRelative_s_Employee_No_())));
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
        if (getTimestamp() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getTimestamp());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getTimestamp(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        if (getEmployee_No_() != null) {
            _hashCode += getEmployee_No_().hashCode();
        }
        _hashCode += getLine_No_();
        if (getRelative_Code() != null) {
            _hashCode += getRelative_Code().hashCode();
        }
        if (getFirst_Name() != null) {
            _hashCode += getFirst_Name().hashCode();
        }
        if (getMiddle_Name() != null) {
            _hashCode += getMiddle_Name().hashCode();
        }
        if (getLast_Name() != null) {
            _hashCode += getLast_Name().hashCode();
        }
        if (getBirth_Date() != null) {
            _hashCode += getBirth_Date().hashCode();
        }
        if (getPhone_No_() != null) {
            _hashCode += getPhone_No_().hashCode();
        }
        if (getRelative_s_Employee_No_() != null) {
            _hashCode += getRelative_s_Employee_No_().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(CRONUS_Sverige_AB_Employee_Relative.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Relative"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("timestamp");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "timestamp"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "base64Binary"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employee_No_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Employee_No_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("line_No_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Line_No_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("relative_Code");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Relative_Code"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("first_Name");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "First_Name"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("middle_Name");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Middle_Name"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("last_Name");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Last_Name"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("birth_Date");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Birth_Date"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("phone_No_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Phone_No_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("relative_s_Employee_No_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Relative_s_Employee_No_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
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
