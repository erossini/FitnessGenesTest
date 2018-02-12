# FitnessGenesTest

Systematic examination (often as peer review) of computer source code intended to find and fix mistakes overlooked in the initial development phase, improving both the overall quality of software and the developers' skills.

The aim of this task is to examine a piece of code that your colleague has written. You must critically analyse and report on the quality of the code and review it for any mistakes, bugs or issues that you feel are present. You can make any comments, improvements or suggestions that you feel are appropriate about style, design and logic.

Please write any review comments inline in the code below in bold red text.

There is no time or word limit but try to not spend too long completing the task – a good guideline is about 30 minutes. Treat it as if it were a real review in your day as a developer.

This example is massively contrived and intentionally badly coded; don't expect code like this in your day to day life.
General comments on the code and design:

public class OrderManager
{
    private readonly IOrderStore orderStore;

    public OrderManager(IOrderStore orderStore)
    {
        this.orderStore = orderStore;
    }

    public void WriteOutSmallOrders()
    {
        var orders = orderStore.GetOrders();
        SmallOrderFilter filter = new SmallOrderFilter(new OrderWriter(), orders);
        filter.WriteOutFiltrdAndPriceSortedOrders(new OrderWriter());
    }

    public void WriteOutLargeOrders()
    {
        var orders = orderStore.GetOrders();
        LargeOrderFilter filter = new LargeOrderFilter(new OrderWriter(), orders);
        filter.WriteOutFiltrdAndPriceSortedOrders(new OrderWriter());
    }
}


public class LargeOrderFilter
{
    private IOrderWriter orderWriter;
    private List<Order> orders;

    public LargeOrderFilter(IOrderWriter orderWriter, List<Order> orders)
    {
        filterSize = "100";
        this.orderWriter = orderWriter;
        this.orders = orders;
    }

    protected string filterSize;

    public void WriteOutFiltrdAndPriceSortedOrders(IOrderWriter writer)
    {
        List<Order> filteredOrders = this.FilterOrdersSmallerThan(orders, filterSize);
        Enumerable.OrderBy(filteredOrders, o => o.Price);

        ObservableCollection<Order> observableCollection =
            new ObservableCollection<Order>();

        foreach (Order o in filteredOrders)
        {
            observableCollection.Add(o);
        }

        writer.WriteOrders(observableCollection);
    }

    protected List<Order> FilterOrdersSmallerThan(List<Order> allOrders, string size)
    {
        List<Order> filtered = new List<Order>();
        for (int i = 0; i <= allOrders.Count; i++)
        {
            int number = orders[i].toNumber(size);

            if (allOrders[i].Size <= number)
            {
                continue;
            }
            else
            {
                filtered.Add(orders[i]);
            }
        }

        return filtered;
    }
}

public class SmallOrderFilter : LargeOrderFilter
{
    public SmallOrderFilter(IOrderWriter orderWriter, List<Order> orders)
        : base(orderWriter, orders)
    {
        filterSize = "10";
    }
}


public class Order
{
    public double Price
    {
        get { return this.dPrice; }
        set { this.dPrice = value; }
    }

    public int Size
    {
        get { return this.iSize; }
        set { this.iSize = value; }
    }

    public string Symbol
    {
        get { return this.sSymbol; }
        set { this.sSymbol = value; }
    }

    private double dPrice;
    private int iSize;
    private string sSymbol;
    public int toNumber(String Input)
    {
        bool canBeConverted = false;
        int n = 0;
        try
        {
            n = Convert.ToInt32(Input);
            if (n != 0) canBeConverted = true;
        }
        catch (Exception ex)
        {
        }

        if (canBeConverted == true)
        {
            return n;
        }
        else
        {
            return 0;
        }
    }
}


// These are stub interfaces that already exist in the system
// They're out of scope of the code review
public interface IOrderWriter
{
    void WriteOrders(IEnumerable<Order> orders);
}

public class OrderWriter : IOrderWriter
{
    public void WriteOrders(IEnumerable<Order> orders)
    {
    }
}

public interface IOrderStore
{
    List<Order> GetOrders();
}
