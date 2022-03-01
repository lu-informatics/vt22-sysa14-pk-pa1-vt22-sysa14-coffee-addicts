import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.sql.Time;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import javax.swing.table.TableColumn;
import javax.swing.table.TableColumnModel;
import javax.swing.table.TableModel;
import java.util.*;

import org.tempuri.*;
public class Controller {
	private JavaGUIview javaGUIview;
	private ServoSoapProxy serverProxy = new ServoSoapProxy();
	
	private WebService1SoapProxy coffeeAddictsProxy = new WebService1SoapProxy();
	
	public Controller(JavaGUIview javaGUIview)  {
		this.javaGUIview = javaGUIview;
		
		
		javaGUIview.getA3c3tableNamesComboBox().addItem("Beans");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Beverage");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Coffee");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Foam");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Milk");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Water");
		
		DrawEmployeeTable();
		declareListeners();
		
	}
	
	public void declareListeners() {
		javaGUIview.getA2C3ReadBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String fileName = javaGUIview.getA2c3fileNameTextField().getText();
					String resultString = serverProxy.findFile(fileName);
					javaGUIview.getA2c3OutputTextArea().setText(resultString);
				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					javaGUIview.getA2c3OutputTextArea().setText("Fatal error occurred! Please contact support.");
				}
				
			}
		});
		
		javaGUIview.getA3c3tableNamesComboBox().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					FillTable(javaGUIview.a3c3tableJTable(), javaGUIview.getA3c3tableNamesComboBox().getSelectedItem().toString());				
				} catch (Exception ex) {
					
				}
			}
		});
		
		javaGUIview.getA4c2AddBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					CRONUS_Sverige_AB_Employee employee = new CRONUS_Sverige_AB_Employee();
					String[] values = new String[5];
					values[0] = javaGUIview.getA4c2FirstNameTextField().getText();
					values[1] = javaGUIview.getA4c2LastNameTextField().getText();
					values[2] = javaGUIview.getA4c2JobTitleTextField().getText();
					values[3] = javaGUIview.getA4c2PhoneNumberTextField().getText();
					values[4] = javaGUIview.getA4c2CityTextField().getText();
					boolean isValid = true;
					
					for(String value : values) {
						if(value.equals("")) {
							javaGUIview.getLblUserMessage().setText("Please fill out all fields.");
							isValid = false;
							break;
						}
					}
					
					if(isValid) {
						employee.setFirst_Name(values[0]);
						employee.setLast_Name(values[1]);
						employee.setJob_Title(values[2]);
						employee.setPhone_No_(values[3]);
						employee.setCity(values[4]);
						employee.setAlt__Address_End_Date(Calendar.getInstance());
						employee.setAlt__Address_Start_Date(Calendar.getInstance());
						employee.setBirth_Date(Calendar.getInstance());
						employee.setEmployment_Date(Calendar.getInstance());
						employee.setInactive_Date(Calendar.getInstance());
						employee.setLast_Date_Modified(Calendar.getInstance());
						employee.setTermination_Date(Calendar.getInstance());
						
						coffeeAddictsProxy.createEmployee(employee);
						DrawEmployeeTable();
						
						javaGUIview.getLblUserMessage().setText("Employee "+employee.getFirst_Name()+" "+employee.getLast_Name()+" has been added.");
						javaGUIview.getA4c2FirstNameTextField().setText("");
						javaGUIview.getA4c2LastNameTextField().setText("");
						javaGUIview.getA4c2JobTitleTextField().setText("");
						javaGUIview.getA4c2PhoneNumberTextField().setText("");
						javaGUIview.getA4c2CityTextField().setText("");
					}

				} catch (Exception ex) {
					ex.printStackTrace();
				}
			}
		});
		
		javaGUIview.getA4c2DeleteBtn().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					JTable table = javaGUIview.getA4c2TableJTable();
					String primaryKey = table.getValueAt(table.getSelectedRow(), 0).toString();
					String firstName = table.getValueAt(table.getSelectedRow(), 1).toString();
					String lastName = table.getValueAt(table.getSelectedRow(), 2).toString();
					coffeeAddictsProxy.deleteEmployee(primaryKey);
					DrawEmployeeTable();
					javaGUIview.getLblUserMessage().setText("Employee " + firstName + " " + lastName + " has been deleted.");
				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} catch(ArrayIndexOutOfBoundsException ae) {
					javaGUIview.getLblUserMessage()
					.setText("Please select a row.");
				}
			}
		});
		
	}
	public void FillTable(JTable table, String tableName){
		
		try {
			Object[][] objects = coffeeAddictsProxy.getTableValuesAsList(tableName);
			DefaultTableModel model = new DefaultTableModel();
			model.setColumnCount(objects[0].length);
			table.setModel(model);
			Object[][] headers = coffeeAddictsProxy.getColumnNamesAsList(tableName);
			for(int i = 0; i < headers.length; i++) {
				JTableHeader tHeader = table.getTableHeader();
				TableColumnModel tableColumnModel = tHeader.getColumnModel();
				TableColumn tc = tableColumnModel.getColumn(i);
				tc.setHeaderValue(headers[i][0]);
				tHeader.repaint();
			}
			
			for(int i = 0; i < objects.length; i++) {
				Object[] obj = objects[i];
				DefaultTableModel tableModel = (DefaultTableModel) table.getModel();
				tableModel.addRow(obj);

			}			
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	
	}
	
	public void DrawTable(String tableName) {
		
	}

	public void DrawEmployeeTable() {
		try {
			CRONUS_Sverige_AB_Employee[] employeeTable = coffeeAddictsProxy.getEmployees();
			JTable empJTable = javaGUIview.getA4c2TableJTable();
			DefaultTableModel model = new DefaultTableModel();
			model.setColumnCount(6);
			
			for (CRONUS_Sverige_AB_Employee cronus_Sverige_AB_Employee : employeeTable) {
				Object[] tmpEmp = new Object[6];
				tmpEmp[0] = cronus_Sverige_AB_Employee.getNo_();
				tmpEmp[1] = cronus_Sverige_AB_Employee.getFirst_Name();
				tmpEmp[2] = cronus_Sverige_AB_Employee.getLast_Name();
				tmpEmp[3] = cronus_Sverige_AB_Employee.getJob_Title();
				tmpEmp[4] = cronus_Sverige_AB_Employee.getPhone_No_();
				tmpEmp[5] = cronus_Sverige_AB_Employee.getCity();
				model.addRow(tmpEmp);
			}
			empJTable.setModel(model);
			
			JTableHeader tHeader = empJTable.getTableHeader();
			TableColumnModel tableColumnModel = tHeader.getColumnModel();
			
			TableColumn tc1 = tableColumnModel.getColumn(0);
			tc1.setHeaderValue("Employee No");
			TableColumn tc2 = tableColumnModel.getColumn(1);
			tc2.setHeaderValue("First Name");
			TableColumn tc3 = tableColumnModel.getColumn(2);
			tc3.setHeaderValue("Last Name");
			TableColumn tc4 = tableColumnModel.getColumn(3);
			tc4.setHeaderValue("Job Title");
			TableColumn tc5 = tableColumnModel.getColumn(4);
			tc5.setHeaderValue("Phone No");
			TableColumn tc6 = tableColumnModel.getColumn(5);
			tc6.setHeaderValue("City");
			tHeader.repaint();
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
