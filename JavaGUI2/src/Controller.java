import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.*;

public class Controller {
	private JavaGUIview javaGUIview;
	private ServoSoapProxy serverProxy = new ServoSoapProxy();
	
	public Controller(JavaGUIview javaGUIview) {
		this.javaGUIview = javaGUIview;
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
	}

	
}
