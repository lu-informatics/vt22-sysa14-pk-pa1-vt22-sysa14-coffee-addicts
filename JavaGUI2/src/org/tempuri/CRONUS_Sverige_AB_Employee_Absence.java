/**
 * CRONUS_Sverige_AB_Employee_Absence.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class CRONUS_Sverige_AB_Employee_Absence  implements java.io.Serializable {
    private byte[] timestamp;

    private int entry_No_;

    private java.lang.String employee_No_;

    private java.util.Calendar from_Date;

    private java.util.Calendar to_Date;

    private java.lang.String cause_of_Absence_Code;

    private java.lang.String description;

    private java.math.BigDecimal quantity;

    private java.lang.String unit_of_Measure_Code;

    private java.math.BigDecimal quantity__Base_;

    private java.math.BigDecimal qty__per_Unit_of_Measure;

    public CRONUS_Sverige_AB_Employee_Absence() {
    }

    public CRONUS_Sverige_AB_Employee_Absence(
           byte[] timestamp,
           int entry_No_,
           java.lang.String employee_No_,
           java.util.Calendar from_Date,
           java.util.Calendar to_Date,
           java.lang.String cause_of_Absence_Code,
           java.lang.String description,
           java.math.BigDecimal quantity,
           java.lang.String unit_of_Measure_Code,
           java.math.BigDecimal quantity__Base_,
           java.math.BigDecimal qty__per_Unit_of_Measure) {
           this.timestamp = timestamp;
           this.entry_No_ = entry_No_;
           this.employee_No_ = employee_No_;
           this.from_Date = from_Date;
           this.to_Date = to_Date;
           this.cause_of_Absence_Code = cause_of_Absence_Code;
           this.description = description;
           this.quantity = quantity;
           this.unit_of_Measure_Code = unit_of_Measure_Code;
           this.quantity__Base_ = quantity__Base_;
           this.qty__per_Unit_of_Measure = qty__per_Unit_of_Measure;
    }


    /**
     * Gets the timestamp value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return timestamp
     */
    public byte[] getTimestamp() {
        return timestamp;
    }


    /**
     * Sets the timestamp value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param timestamp
     */
    public void setTimestamp(byte[] timestamp) {
        this.timestamp = timestamp;
    }


    /**
     * Gets the entry_No_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return entry_No_
     */
    public int getEntry_No_() {
        return entry_No_;
    }


    /**
     * Sets the entry_No_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param entry_No_
     */
    public void setEntry_No_(int entry_No_) {
        this.entry_No_ = entry_No_;
    }


    /**
     * Gets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return employee_No_
     */
    public java.lang.String getEmployee_No_() {
        return employee_No_;
    }


    /**
     * Sets the employee_No_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param employee_No_
     */
    public void setEmployee_No_(java.lang.String employee_No_) {
        this.employee_No_ = employee_No_;
    }


    /**
     * Gets the from_Date value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return from_Date
     */
    public java.util.Calendar getFrom_Date() {
        return from_Date;
    }


    /**
     * Sets the from_Date value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param from_Date
     */
    public void setFrom_Date(java.util.Calendar from_Date) {
        this.from_Date = from_Date;
    }


    /**
     * Gets the to_Date value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return to_Date
     */
    public java.util.Calendar getTo_Date() {
        return to_Date;
    }


    /**
     * Sets the to_Date value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param to_Date
     */
    public void setTo_Date(java.util.Calendar to_Date) {
        this.to_Date = to_Date;
    }


    /**
     * Gets the cause_of_Absence_Code value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return cause_of_Absence_Code
     */
    public java.lang.String getCause_of_Absence_Code() {
        return cause_of_Absence_Code;
    }


    /**
     * Sets the cause_of_Absence_Code value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param cause_of_Absence_Code
     */
    public void setCause_of_Absence_Code(java.lang.String cause_of_Absence_Code) {
        this.cause_of_Absence_Code = cause_of_Absence_Code;
    }


    /**
     * Gets the description value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return description
     */
    public java.lang.String getDescription() {
        return description;
    }


    /**
     * Sets the description value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param description
     */
    public void setDescription(java.lang.String description) {
        this.description = description;
    }


    /**
     * Gets the quantity value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return quantity
     */
    public java.math.BigDecimal getQuantity() {
        return quantity;
    }


    /**
     * Sets the quantity value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param quantity
     */
    public void setQuantity(java.math.BigDecimal quantity) {
        this.quantity = quantity;
    }


    /**
     * Gets the unit_of_Measure_Code value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return unit_of_Measure_Code
     */
    public java.lang.String getUnit_of_Measure_Code() {
        return unit_of_Measure_Code;
    }


    /**
     * Sets the unit_of_Measure_Code value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param unit_of_Measure_Code
     */
    public void setUnit_of_Measure_Code(java.lang.String unit_of_Measure_Code) {
        this.unit_of_Measure_Code = unit_of_Measure_Code;
    }


    /**
     * Gets the quantity__Base_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return quantity__Base_
     */
    public java.math.BigDecimal getQuantity__Base_() {
        return quantity__Base_;
    }


    /**
     * Sets the quantity__Base_ value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param quantity__Base_
     */
    public void setQuantity__Base_(java.math.BigDecimal quantity__Base_) {
        this.quantity__Base_ = quantity__Base_;
    }


    /**
     * Gets the qty__per_Unit_of_Measure value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @return qty__per_Unit_of_Measure
     */
    public java.math.BigDecimal getQty__per_Unit_of_Measure() {
        return qty__per_Unit_of_Measure;
    }


    /**
     * Sets the qty__per_Unit_of_Measure value for this CRONUS_Sverige_AB_Employee_Absence.
     * 
     * @param qty__per_Unit_of_Measure
     */
    public void setQty__per_Unit_of_Measure(java.math.BigDecimal qty__per_Unit_of_Measure) {
        this.qty__per_Unit_of_Measure = qty__per_Unit_of_Measure;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof CRONUS_Sverige_AB_Employee_Absence)) return false;
        CRONUS_Sverige_AB_Employee_Absence other = (CRONUS_Sverige_AB_Employee_Absence) obj;
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
            this.entry_No_ == other.getEntry_No_() &&
            ((this.employee_No_==null && other.getEmployee_No_()==null) || 
             (this.employee_No_!=null &&
              this.employee_No_.equals(other.getEmployee_No_()))) &&
            ((this.from_Date==null && other.getFrom_Date()==null) || 
             (this.from_Date!=null &&
              this.from_Date.equals(other.getFrom_Date()))) &&
            ((this.to_Date==null && other.getTo_Date()==null) || 
             (this.to_Date!=null &&
              this.to_Date.equals(other.getTo_Date()))) &&
            ((this.cause_of_Absence_Code==null && other.getCause_of_Absence_Code()==null) || 
             (this.cause_of_Absence_Code!=null &&
              this.cause_of_Absence_Code.equals(other.getCause_of_Absence_Code()))) &&
            ((this.description==null && other.getDescription()==null) || 
             (this.description!=null &&
              this.description.equals(other.getDescription()))) &&
            ((this.quantity==null && other.getQuantity()==null) || 
             (this.quantity!=null &&
              this.quantity.equals(other.getQuantity()))) &&
            ((this.unit_of_Measure_Code==null && other.getUnit_of_Measure_Code()==null) || 
             (this.unit_of_Measure_Code!=null &&
              this.unit_of_Measure_Code.equals(other.getUnit_of_Measure_Code()))) &&
            ((this.quantity__Base_==null && other.getQuantity__Base_()==null) || 
             (this.quantity__Base_!=null &&
              this.quantity__Base_.equals(other.getQuantity__Base_()))) &&
            ((this.qty__per_Unit_of_Measure==null && other.getQty__per_Unit_of_Measure()==null) || 
             (this.qty__per_Unit_of_Measure!=null &&
              this.qty__per_Unit_of_Measure.equals(other.getQty__per_Unit_of_Measure())));
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
        _hashCode += getEntry_No_();
        if (getEmployee_No_() != null) {
            _hashCode += getEmployee_No_().hashCode();
        }
        if (getFrom_Date() != null) {
            _hashCode += getFrom_Date().hashCode();
        }
        if (getTo_Date() != null) {
            _hashCode += getTo_Date().hashCode();
        }
        if (getCause_of_Absence_Code() != null) {
            _hashCode += getCause_of_Absence_Code().hashCode();
        }
        if (getDescription() != null) {
            _hashCode += getDescription().hashCode();
        }
        if (getQuantity() != null) {
            _hashCode += getQuantity().hashCode();
        }
        if (getUnit_of_Measure_Code() != null) {
            _hashCode += getUnit_of_Measure_Code().hashCode();
        }
        if (getQuantity__Base_() != null) {
            _hashCode += getQuantity__Base_().hashCode();
        }
        if (getQty__per_Unit_of_Measure() != null) {
            _hashCode += getQty__per_Unit_of_Measure().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(CRONUS_Sverige_AB_Employee_Absence.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", "CRONUS_Sverige_AB_Employee_Absence"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("timestamp");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "timestamp"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "base64Binary"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("entry_No_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Entry_No_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
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
        elemField.setFieldName("cause_of_Absence_Code");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Cause_of_Absence_Code"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
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
        elemField.setFieldName("quantity");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Quantity"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("unit_of_Measure_Code");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Unit_of_Measure_Code"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("quantity__Base_");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Quantity__Base_"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("qty__per_Unit_of_Measure");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "Qty__per_Unit_of_Measure"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
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
