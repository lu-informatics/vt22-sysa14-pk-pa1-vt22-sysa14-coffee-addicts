import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import javax.swing.table.TableColumn;
import javax.swing.table.TableColumnModel;
import org.tempuri.*;
public class Controller {
	private JavaGUIview javaGUIview;
	private ServoSoapProxy serverProxy = new ServoSoapProxy();
	
	private WebService1SoapProxy coffeeAddictsProxy = new WebService1SoapProxy();
	
	public Controller(JavaGUIview javaGUIview) {
		this.javaGUIview = javaGUIview;
		declareListeners();
		
		javaGUIview.getA3c3tableNamesComboBox().addItem("Beans");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Beverage");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Coffee");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Foam");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Milk");
		javaGUIview.getA3c3tableNamesComboBox().addItem("Water");
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

	
}
