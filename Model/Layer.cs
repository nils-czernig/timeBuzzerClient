using System.Collections.Generic;

public class Layer
{
    public List<int> children { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public bool visible { get; set; }
    public int template { get; set; }
    public int parent { get; set; }
}