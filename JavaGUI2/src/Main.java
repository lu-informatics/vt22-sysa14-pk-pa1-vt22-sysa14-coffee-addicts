import java.awt.EventQueue;

public class Main {
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		/*
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					JavaGUIview window = new JavaGUIview();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	*/
		
		JavaGUIview javaGUIview = new JavaGUIview();
		Controller controller = new Controller(javaGUIview);
	}

}
