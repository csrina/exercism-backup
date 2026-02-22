public static class TelemetryBuffer
{
    //short = 2 byte
    //int = 4 byte
    //long = 8 byte
    //65_535
    public static byte[] ToBuffer(long reading)
    {
        byte[] arr;
        int byteCount = 8;
        byte[] res = new byte[byteCount+1];
        // if((reading >= 4_294_967_296 && reading <= 9_223_372_036_854_775_807)||(reading >= -9_223_372_036_854_775_808 && reading <= -2_147_483_649))
        // {
        //     // treat as long
        //     arr = BitConverter.GetBytes(reading);
        //     res[0] = (byte)(256-arr.Length);
        // }
        if(reading >= 2_147_483_648 && reading <= 4_294_967_295)
        {
            // treat as uint
            arr = BitConverter.GetBytes((UInt32)reading);
            res[0] = (byte)(byteCount-arr.Length);
        }
        else if((reading >= 65_536 && reading <= 2_147_483_647)||(reading >= -2_147_483_648 && reading <= -32_769))
        {
            // treat as int
            arr = BitConverter.GetBytes((Int32)reading);
            res[0] = (byte)(256-arr.Length);
        }
        else if(reading >= -32_768 && reading <= -1)
        {
            // treat as short
            arr = BitConverter.GetBytes((Int16)reading);
            res[0] = (byte)(256-arr.Length);
        }
        else if(reading >= 0 && reading <= 65_535)
        {
            // treat as ushort
            // 8 -
            arr = BitConverter.GetBytes((UInt16)reading);
            res[0] = (byte)(arr.Length);
        }
        else{
            // treat as long
            arr = BitConverter.GetBytes(reading);
            res[0] = (byte)(256-arr.Length);
            
        }
        for (int i = 0; i < arr.Length; i++)
        {
            res[i + 1] = arr[i];
        }
        return res;
    }
    public static long FromBuffer(byte[] buffer)
    {
        var b = (byte)buffer[0];
        switch (b)
        {
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case 4:
                return BitConverter.ToUInt32(buffer, 1);
            case 254:
                return BitConverter.ToInt16(buffer, 1);
            case 252:
                return BitConverter.ToInt32(buffer, 1);
            case 248:
                return BitConverter.ToInt64(buffer, 1);
            default:
                return 0;
        }
    }
}
