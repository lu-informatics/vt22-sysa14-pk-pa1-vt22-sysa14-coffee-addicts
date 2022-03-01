import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JTabbedPane;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JWindow;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.security.PublicKey;
import java.awt.event.ActionEvent;
import javax.swing.JComboBox;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JScrollBar;
import javax.swing.ScrollPaneConstants;

public class JavaGUIview extends JWindow{

	private JFrame frame;
	private JTextField a2c3fileNameTextField;
	private JButton a2c3ReadBtn;
	private JTextArea a2c3OutputTextArea;
	private JTable a3c3tableJTable;
	private JComboBox<String> a3c3tableNamesComboBox;
	private JTable a4c2TableJTable;
	private JTextField a4c2FirstNameTextField;
	private JTextField a4c2LastNameTextField;
	private JTextField a4c2JobTitleTextField;
	private JTextField a4c2PhoneNumberTextField;
	private JTextField a4c2CityTextField;
	private JButton a4c2AddBtn;
	private JButton a4c2DeleteBtn;
	private JLabel lblUserMessage;
	private JPanel a5c2_tab;
	private JScrollPane scrollPane_2;
	private JTable a5c2_1tableJTable;
	private JLabel lblNewLabel_6;
	private JComboBox<String> a5c2_1tableJComboBox;

	

	/**
	 * Create the application.
	 */
	public JavaGUIview(){
		initialize();
		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 903, 560);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setBounds(0, 0, 887, 521);
		frame.getContentPane().add(tabbedPane);
		
		JPanel a2c3tab = new JPanel();
		tabbedPane.addTab("Assignment 2", null, a2c3tab, null);
		a2c3tab.setLayout(null);
		
		JLabel a2c3lbl = new JLabel("File name:");
		a2c3lbl.setBounds(262, 151, 59, 14);
		a2c3tab.add(a2c3lbl);
		
		a2c3fileNameTextField = new JTextField();
		a2c3fileNameTextField.setBounds(319, 148, 130, 20);
		a2c3tab.add(a2c3fileNameTextField);
		a2c3fileNameTextField.setColumns(10);
		
		a2c3ReadBtn = new JButton("Read");
		
		a2c3ReadBtn.setBounds(459, 147, 89, 23);
		a2c3tab.add(a2c3ReadBtn);
		
		a2c3OutputTextArea = new JTextArea();
		a2c3OutputTextArea.setLineWrap(true);
		a2c3OutputTextArea.setEditable(false);
		a2c3OutputTextArea.setBounds(262, 194, 286, 187);
		a2c3tab.add(a2c3OutputTextArea);
		
		JPanel a3c3_tab = new JPanel();
		tabbedPane.addTab("Assignment 3", null, a3c3_tab, null);
		a3c3_tab.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("Table name:");
		lblNewLabel.setBounds(289, 409, 62, 14);
		a3c3_tab.add(lblNewLabel);
		
		a3c3tableNamesComboBox = new JComboBox();
		
		a3c3tableNamesComboBox.setBounds(354, 405, 176, 22);
		a3c3_tab.add(a3c3tableNamesComboBox);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 862, 367);
		a3c3_tab.add(scrollPane);
		
		a3c3tableJTable = new JTable();
		a3c3tableJTable.setEnabled(false);
		scrollPane.setViewportView(a3c3tableJTable);
		
		JPanel a4c2_tab = new JPanel();
		tabbedPane.addTab("Assignment 4", null, a4c2_tab, null);
		a4c2_tab.setLayout(null);
		
		JScrollPane scrollPane_1 = new JScrollPane();
		scrollPane_1.setBounds(10, 11, 862, 250);
		a4c2_tab.add(scrollPane_1);
		
		a4c2TableJTable = new JTable() {
			@Override
			 public boolean isCellEditable(int row, int column) {
		        return column != 0 ? true : false;
		    }
		};
		scrollPane_1.setViewportView(a4c2TableJTable);
		
		JLabel lblNewLabel_1 = new JLabel("First Name");
		lblNewLabel_1.setBounds(10, 302, 65, 14);
		a4c2_tab.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Last Name");
		lblNewLabel_2.setBounds(10, 377, 65, 14);
		a4c2_tab.add(lblNewLabel_2);
		
		a4c2FirstNameTextField = new JTextField();
		a4c2FirstNameTextField.setBounds(77, 299, 130, 20);
		a4c2_tab.add(a4c2FirstNameTextField);
		a4c2FirstNameTextField.setColumns(10);
		
		a4c2LastNameTextField = new JTextField();
		a4c2LastNameTextField.setBounds(77, 374, 130, 20);
		a4c2_tab.add(a4c2LastNameTextField);
		a4c2LastNameTextField.setColumns(10);
		
		JLabel lblNewLabel_3 = new JLabel("Job Title");
		lblNewLabel_3.setBounds(307, 302, 56, 14);
		a4c2_tab.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Phone #");
		lblNewLabel_4.setBounds(307, 377, 56, 14);
		a4c2_tab.add(lblNewLabel_4);
		
		a4c2JobTitleTextField = new JTextField();
		a4c2JobTitleTextField.setBounds(367, 299, 130, 20);
		a4c2_tab.add(a4c2JobTitleTextField);
		a4c2JobTitleTextField.setColumns(10);
		
		a4c2PhoneNumberTextField = new JTextField();
		a4c2PhoneNumberTextField.setBounds(367, 374, 130, 20);
		a4c2_tab.add(a4c2PhoneNumberTextField);
		a4c2PhoneNumberTextField.setColumns(10);
		
		JLabel lblNewLabel_5 = new JLabel("City");
		lblNewLabel_5.setBounds(589, 302, 30, 14);
		a4c2_tab.add(lblNewLabel_5);
		
		a4c2CityTextField = new JTextField();
		a4c2CityTextField.setBounds(623, 299, 130, 20);
		a4c2_tab.add(a4c2CityTextField);
		a4c2CityTextField.setColumns(10);
		
		a4c2AddBtn = new JButton("Add");
		a4c2AddBtn.setBounds(298, 437, 89, 23);
		a4c2_tab.add(a4c2AddBtn);
		
		a4c2DeleteBtn = new JButton("Delete");
		a4c2DeleteBtn.setBounds(443, 437, 89, 23);
		a4c2_tab.add(a4c2DeleteBtn);
		
		lblUserMessage = new JLabel("");
		lblUserMessage.setBounds(10, 468, 862, 14);
		a4c2_tab.add(lblUserMessage);
		
		a5c2_tab = new JPanel();
		tabbedPane.addTab("Assignment 5.1", null, a5c2_tab, null);
		a5c2_tab.setLayout(null);
		
		scrollPane_2 = new JScrollPane();
		scrollPane_2.setBounds(10, 11, 862, 304);
		a5c2_tab.add(scrollPane_2);
		
		a5c2_1tableJTable = new JTable();
		scrollPane_2.setViewportView(a5c2_1tableJTable);
		
		lblNewLabel_6 = new JLabel("Choose table:");
		lblNewLabel_6.setBounds(84, 379, 84, 14);
		a5c2_tab.add(lblNewLabel_6);
		
		a5c2_1tableJComboBox = new JComboBox();
		a5c2_1tableJComboBox.setMaximumRowCount(20);
		a5c2_1tableJComboBox.setBounds(178, 375, 195, 22);
		a5c2_tab.add(a5c2_1tableJComboBox);
		frame.setVisible(true);
	}
	
	public JTable getA5c2_1tableJTable() {
		return a5c2_1tableJTable;
	}

	public JButton getA2C3ReadBtn() {
		return this.a2c3ReadBtn;
	}

	public JTextField getA2c3fileNameTextField() {
		return a2c3fileNameTextField;
	}

	public JTextArea getA2c3OutputTextArea() {
		return a2c3OutputTextArea;
	}
	
	public JComboBox<String> getA3c3tableNamesComboBox() {
		return a3c3tableNamesComboBox;
	}
	
	public JTable a3c3tableJTable() {
		return a3c3tableJTable;
	}

	public JTable getA4c2TableJTable() {
		return a4c2TableJTable;
	}

	public JTextField getA4c2FirstNameTextField() {
		return a4c2FirstNameTextField;
	}

	public JTextField getA4c2LastNameTextField() {
		return a4c2LastNameTextField;
	}

	public JTextField getA4c2JobTitleTextField() {
		return a4c2JobTitleTextField;
	}

	public JTextField getA4c2PhoneNumberTextField() {
		return a4c2PhoneNumberTextField;
	}

	public JTextField getA4c2CityTextField() {
		return a4c2CityTextField;
	}

	public JButton getA4c2AddBtn() {
		return a4c2AddBtn;
	}

	public JButton getA4c2DeleteBtn() {
		return a4c2DeleteBtn;
	}

	public JLabel getLblUserMessage() {
		return lblUserMessage;
	}

	public JComboBox<String> getA5c2_1tableJComboBox() {
		return a5c2_1tableJComboBox;
	}
    
	
	
}
