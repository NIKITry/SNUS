using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;

public class instruction : MonoBehaviour
{
    string path = Directory.GetCurrentDirectory();

    public void instractionBt()
    {
        Process.Start(new ProcessStartInfo(path + @"/VNS_INSTRUCTION.docx") { WindowStyle = ProcessWindowStyle.Maximized });
    }
}
