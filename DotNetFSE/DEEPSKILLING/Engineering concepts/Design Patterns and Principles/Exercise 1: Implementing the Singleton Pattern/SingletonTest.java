public class SingletonTest {

    public static void main(String[] args) {

        // Get Logger instance
        Logger logger1 = Logger.getInstance();
        logger1.log("Application Started");

        // Get Logger instance again
        Logger logger2 = Logger.getInstance();
        logger2.log("User Logged In");

        // Compare both references
        if (logger1 == logger2) {
            System.out.println("Both logger objects are the same.");
        } else {
            System.out.println("Different logger objects created.");
        }

        // Print hashcodes
        System.out.println("Logger1 HashCode: " + logger1.hashCode());
        System.out.println("Logger2 HashCode: " + logger2.hashCode());
    }
}