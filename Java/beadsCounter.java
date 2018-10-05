public class BeadsCounter {
    public static int countRedBeads(final int nBlue) {
        if (nBlue == 0)
            return 0;
        return (nBlue * 2) - 2;
    }
}