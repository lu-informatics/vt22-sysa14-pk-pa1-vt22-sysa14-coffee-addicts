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
import java.awt.event.ActionEvent;
import javax.swing.JComboBox;
import javax.swing.JTable;
import javax.swing.JScrollPane;

public class JavaGUIview extends JWindow{

	private JFrame frame;
	private JTextField a2c3fileNameTextField;
	private JButton a2c3ReadBtn;
	private JTextArea a2c3OutputTextArea;
	private JTable a3c3tableJTable;
	private JComboBox<String> a3c3tableNamesComboBox;

	

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
		
		JPanel panel_2 = new JPanel();
		tabbedPane.addTab("New tab", null, panel_2, null);
		
		JPanel panel_3 = new JPanel();
		tabbedPane.addTab("New tab", null, panel_3, null);
		frame.setVisible(true);
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
}
