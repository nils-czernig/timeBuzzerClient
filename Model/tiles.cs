using System.Collections.Generic;

public class tiles
{
    public int id { get; set; }
    public string name { get; set; }
    public bool archived { get; set; }
    public int type { get; set; }
    public int layer { get; set; }
    public List<int> parents { get; set; }
}