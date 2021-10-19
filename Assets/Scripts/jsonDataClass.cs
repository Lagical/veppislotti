using System;
using System.Collections.Generic;

[Serializable]
public class jsonDataClass
{
    //public string [] koodi2;
    public List<allCodes> koodi2;
}

[Serializable]
public class allCodes
{
    public string koodi;
}
