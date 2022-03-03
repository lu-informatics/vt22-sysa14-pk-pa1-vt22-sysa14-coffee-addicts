/**
 * CRONUS_Sverige_AB_Employee_Qualification.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class CRONUS_Sverige_AB_Employee_Qualification  implements java.io.Serializable {
    private byte[] timestamp;

    private java.lang.String employee_No_;

    private int line_No_;

    private java.lang.String qualification_Code;

    private java.util.Calendar from_Date;

    private java.util.Calendar to_Date;

    private int type;

    private java.lang.String description;

    private java.lang.String institution_Company;

    private java.math.BigDecimal cost;

    private java.lang.String course_Grade;

    private int employee_Status;

    private java.util.Calendar expiration_Date;

    public CRONUS_Sverige_AB_Employee_Qualification() {
    }

    public CRONUS_Sverige_AB_Employee_Qualification(
           byte[] timestamp,
           java.lang.String employee_No_,
           int line_No_,
           java.lang.String qualification_Code,
           java.util.Calendar from_Date,
           java.util.Calendar to_Date,
           int type,
           java.lang.String description,
           java.lang.String institution_Company,
           java.math.BigDecimal cost,
           java.lang.String course_Grade,
           int employee_Status,
           java.util.Calendar expiration_Date) {
           this.timestamp = timestamp;
           this.employee_No_ = employee_No_;
           this.line_No_ = line_No_;
           this.qualification_Code = qualification_Code;
           this.from_Date = from_Date;
           this.to_Date = to_Date;
           this.type = type;
           this.description = description;
           this.institution_Company = institution_Company;
           this.cost = cost;
           this.course_Grade = course_Grade;
           this.employee_Status = employee_Status;
           this.expiration_Date = expiration_Date;
    }


    /**
     * Gets the timestamp value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return timestamp
     */
    public byte[] getTimestamp() {
        return timestamp;
    }


    /**
     * Sets the timestamp value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param timestamp
     */
    public void setTimestamp(byte[] timestamp) {
        this.timestamp = timestamp;
    }


    /**
     * Gets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return employee_No_
     */
    public java.lang.String getEmployee_No_() {
        return employee_No_;
    }


    /**
     * Sets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param employee_No_
     */
    public void setEmployee_No_(java.lang.String employee_No_) {
        this.employee_No_ = employee_No_;
    }


    /**
     * Gets the line_No_ value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return line_No_
     */
    public int getLine_No_() {
        return line_No_;
    }


    /**
     * Sets the line_No_ value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param line_No_
     */
    public void setLine_No_(int line_No_) {
        this.line_No_ = line_No_;
    }


    /**
     * Gets the qualification_Code value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return qualification_Code
     */
    public java.lang.String getQualification_Code() {
        return qualification_Code;
    }


    /**
     * Sets the qualification_Code value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param qualification_Code
     */
    public void setQualification_Code(java.lang.String qualification_Code) {
        this.qualification_Code = qualification_Code;
    }


    /**
     * Gets the from_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return from_Date
     */
    public java.util.Calendar getFrom_Date() {
        return from_Date;
    }


    /**
     * Sets the from_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param from_Date
     */
    public void setFrom_Date(java.util.Calendar from_Date) {
        this.from_Date = from_Date;
    }


    /**
     * Gets the to_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return to_Date
     */
    public java.util.Calendar getTo_Date() {
        return to_Date;
    }


    /**
     * Sets the to_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param to_Date
     */
    public void setTo_Date(java.util.Calendar to_Date) {
        this.to_Date = to_Date;
    }


    /**
     * Gets the type value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return type
     */
    public int getType() {
        return type;
    }


    /**
     * Sets the type value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param type
     */
    public void setType(int type) {
        this.type = type;
    }


    /**
     * Gets the description value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return description
     */
    public java.lang.String getDescription() {
        return description;
    }


    /**
     * Sets the description value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param description
     */
    public void setDescription(java.lang.String description) {
        this.description = description;
    }


    /**
     * Gets the institution_Company value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return institution_Company
     */
    public java.lang.String getInstitution_Company() {
        return institution_Company;
    }


    /**
     * Sets the institution_Company value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param institution_Company
     */
    public void setInstitution_Company(java.lang.String institution_Company) {
        this.institution_Company = institution_Company;
    }


    /**
     * Gets the cost value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return cost
     */
    public java.math.BigDecimal getCost() {
        return cost;
    }


    /**
     * Sets the cost value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param cost
     */
    public void setCost(java.math.BigDecimal cost) {
        this.cost = cost;
    }


    /**
     * Gets the course_Grade value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return course_Grade
     */
    public java.lang.String getCourse_Grade() {
        return course_Grade;
    }


    /**
     * Sets the course_Grade value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param course_Grade
     */
    public void setCourse_Grade(java.lang.String course_Grade) {
        this.course_Grade = course_Grade;
    }


    /**
     * Gets the employee_Status value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return employee_Status
     */
    public int getEmployee_Status() {
        return employee_Status;
    }


    /**
     * Sets the employee_Status value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param employee_Status
     */
    public void setEmployee_Status(int employee_Status) {
        this.employee_Status = employee_Status;
    }


    /**
     * Gets the expiration_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @return expiration_Date
     */
    public java.util.Calendar getExpiration_Date() {
        return expiration_Date;
    }


    /**
     * Sets the expiration_Date value for this CRONUS_Sverige_AB_Employee_Qualification.
     * 
     * @param expiration_Date
     */
    public void setExpiration_Date(java.util.Calendar expiration_Date) {
        this.expiration_Date = expiration_Date;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof CRONUS_Sverige_AB_Employee_Qualification)) return false;
        CRONUS_Sverige_AB_Employee_Qualification other = (CRONUS_Sverige_AB_Employee_Qualification) obj;
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
            ((this.qualification_Code==null && other.getQualification_Code()==null) || 
             (this.qualification_Code!=null &&
              this.qualification_Code.equals(other.getQualification_Code()))) &&
            ((this.from_Date==null && other.getFrom_Date()==null) || 
             (this.from_Date!=null &&
              this.from_Date.equals(other.getFrom_Date()))) &&
            ((this.to_Date==null && other.getTo_Date()==null) || 
             (this.to_Date!=null &&
              this.to_Date.equals(other.getTo_Date()))) &&
            this.type == other.getType() &&
            ((this.description==null && other.getDescription()==null) || 
             (this.description!=null &&
              this.description.equals(other.getDescription()))) &&
            ((this.institution_Company==null && other.getInstitution_Company()==null) || 
             (this.institution_Company!=null &&
              this.institution_Company.equals(other.getInstitution_Company()))) &&
            ((this.cost==null && other.getCost()==null) || 
             (this.cost!=null &&
              this.cost.equals(other.getCost()))) &&
            ((this.course_Grade==null && other.getCourse_Grade()==null) || 
             (this.course_Grade!=null &&
              this.course_Grade.equals(other.getCourse_Grade()))) &&
            this.employee_Status == other.getEmployee_Status() &&
            ((this.expiration_Date==null && other.getExpiration_Date()==null) || 
             (this.expiration_Date!=null &&
              this.expiration_Date.equals(other.getExpiration_Date())));
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
        if (getQualification_Code() != null) {
            _hashCode += getQualification_Code().hashCode();
        }
        if (getFrom_Date() != null) {
            _hashCode += getFrom_Date().hashCode();
        }
        if (getTo_Date() != null) {
            _hashCode += getTo_Date().hashCode();
        }
        _hashCode += getType();
        if (getDescription() != null) {
            _hashCode += getDescription().hashCode();
        }
        if (getInstitution_Company() != null) {
            _hashCode += getInstitution_Company().hashCode();
        }
        if (getCost() != null) {
            _hashCode += getCost().hashCode();
        }
        if (getCourse_Grade() != null) {
            _hashCode += getCourse_Grade().hashCode();
        }
        _hashCode += getEmployee_Status();
        if (getExpiration_Date() != null) {
            _hashCode += getExpiration_Date().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(CRONUS_Sverige_AB_Employee_Qualification.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Qualification"));
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
        elemField.setFieldName("qualification_Code");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Qualification_Code"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("from_Date");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "From_Date"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("to_Date");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "To_Date"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("type");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Type"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("description");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Description"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("institution_Company");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Institution_Company"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("cost");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Cost"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("course_Grade");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Course_Grade"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employee_Status");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Employee_Status"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("expiration_Date");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Expiration_Date"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
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
