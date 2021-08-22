import java.util.Locale;
import java.sql.Date;

public class PrintTest {
	public static void main(String[] args){

		Date data = new Date(0);
		System.out.printf(Locale.GERMANY, "Ngày giờ hiện tại: %tc", data);
	}
}
