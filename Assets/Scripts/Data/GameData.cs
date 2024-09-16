public class GameData
{
    public int coin;

    public bool[] buyBackground = new bool[4];
    public bool[] buyBasket = new bool[5];

    public GameData()
    {
        coin = 0;

        buyBackground[0] = true;
        buyBackground[1] = false;
        buyBackground[2] = false;
        buyBackground[3] = false;

        buyBasket[0] = true;
        buyBasket[1] = false;
        buyBasket[2] = false;
        buyBasket[3] = false;
        buyBasket[4] = false;
    }
}
