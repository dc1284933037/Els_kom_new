// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.
/* define if not defined already. */
#if !KOMV3
#define KOMV3
#endif

namespace komv3_plugin
{
    public class Komv3_plugin : Els_kom_Core.interfaces.IKomPlugin
    {
        public string PluginName => "KOM V3 Plugin";
        public string KOMHeaderString => "KOG GC TEAM MASSFILE V.0.3.";
        public int SupportedKOMVersion => 3;

        public void Pack(string in_path, string out_path, string KOMFileName)
        {
            // not implemented yet due to lack of packing information on v3 koms.
            throw new System.NotImplementedException();
        }

        public void Unpack(string in_path, string out_path, string KOMFileName)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.OpenRead(in_path), System.Text.Encoding.ASCII);
            reader.BaseStream.Position += 52;
            int entry_count = (int)reader.ReadUInt64();
            reader.BaseStream.Position += 4;
            int file_time = reader.ReadInt32();
            int xml_size = reader.ReadInt32();
            byte[] xmldatabuffer = reader.ReadBytes(xml_size);
            string xmldata = System.Text.Encoding.ASCII.GetString(xmldatabuffer);
            Els_kom_Core.Classes.KOMStream kOMStream = new Els_kom_Core.Classes.KOMStream();
            System.Collections.Generic.List<Els_kom_Core.Classes.EntryVer> entries = kOMStream.Make_entries_v3(xmldata, entry_count);
            foreach (var entry in entries)
            {
                // we iterate through every entry here and unpack the data.
                kOMStream.WriteOutput(reader, out_path, entry, SupportedKOMVersion);
            }
            kOMStream.Dispose();
            reader.Dispose();
        }

        public void Delete(string in_path, bool folder)
        {
        }
    }
}
