import java.util.Random;

public class GenerateColorRGB {

    public static String generateColor(Random r) {
        return String.format("#%06x", r.nextInt(0xffffff + 1));
    }

}
