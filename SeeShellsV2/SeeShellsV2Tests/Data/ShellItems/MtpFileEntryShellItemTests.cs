﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeShellsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeShellsV2.Data.Tests
{
    [TestClass()]
    public class MtpFileEntryShellItemTests
    {
        [TestMethod()]
        public void MtpFileEntryShellItemTest()
        {
            MtpFileEntryShellItem item = new MtpFileEntryShellItem()
            {
                Type = 0x00,
                TypeName = "TestType",
                Description = "Test",
                Size = 10,
                ModifiedDate = new DateTime(90810298),
                AccessedDate = new DateTime(908123802123),
                CreationDate = new DateTime(4865846),
                FolderName = "Internal Storage",
                FolderId = "123ABC",
            };

            Assert.IsTrue(item.Fields.Count == 9);
            Assert.IsTrue(item.Fields.ContainsKey("Type"));
            Assert.IsTrue(item.Fields["Type"] as byte? == item.Type);
            Assert.IsTrue(item.Type == 0x00);
            Assert.IsTrue(item.Fields.ContainsKey("TypeName"));
            Assert.IsTrue(item.Fields["TypeName"] as string == item.TypeName);
            Assert.IsTrue(item.TypeName == "TestType");
            Assert.IsTrue(item.Fields.ContainsKey("Description"));
            Assert.IsTrue(item.Fields["Description"] as string == item.Description);
            Assert.IsTrue(item.Description == "Test");
            Assert.IsTrue(item.Fields.ContainsKey("Size"));
            Assert.IsTrue(item.Fields["Size"] as ushort? == item.Size);
            Assert.IsTrue(item.Size == 10);
            Assert.IsTrue(item.Fields.ContainsKey("ModifiedDate"));
            Assert.IsTrue(item.Fields["ModifiedDate"] as DateTime? == item.ModifiedDate);
            Assert.IsTrue(item.ModifiedDate == new DateTime(90810298));
            Assert.IsTrue(item.Fields.ContainsKey("AccessedDate"));
            Assert.IsTrue(item.Fields["AccessedDate"] as DateTime? == item.AccessedDate);
            Assert.IsTrue(item.AccessedDate == new DateTime(908123802123));
            Assert.IsTrue(item.Fields.ContainsKey("CreationDate"));
            Assert.IsTrue(item.Fields["CreationDate"] as DateTime? == item.CreationDate);
            Assert.IsTrue(item.CreationDate == new DateTime(4865846));
            Assert.IsTrue(item.Fields.ContainsKey("FolderName"));
            Assert.IsTrue(item.Fields["FolderName"] as string == item.FolderName);
            Assert.IsTrue(item.FolderName == "Internal Storage");
            Assert.IsTrue(item.Fields.ContainsKey("FolderId"));
            Assert.IsTrue(item.Fields["FolderId"] as string == item.FolderId);
            Assert.IsTrue(item.FolderId == "123ABC");
            Assert.IsTrue(item.RegistryKey == null);
        }

        [TestMethod()]
        public void MtpFileEntryShellItemTest1()
        {
            byte[] buf = new byte[] {
                0x2A, 0x02, 0x00, 0x00, 0x24, 0x02, 0x06, 0x20,
                0x19, 0x07, 0x7B, 0x00, 0x00, 0x00, 0x02, 0x00,
                0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x80, 0x9C, 0xE1, 0xDC, 0xB0, 0x37,
                0xD1, 0x01, 0x80, 0x9C, 0xE1, 0xDC, 0xB0, 0x37,
                0xD1, 0x01, 0x92, 0xE3, 0xE2, 0x27, 0x11, 0xA1,
                0xE0, 0x48, 0xAB, 0x0C, 0xE1, 0x77, 0x05, 0xA0,
                0x5F, 0x85, 0x84, 0x01, 0x00, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x27, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x44, 0x00, 0x43, 0x00,
                0x49, 0x00, 0x4D, 0x00, 0x00, 0x00, 0x7B, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x31, 0x00,
                0x2D, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x2D, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x2D, 0x00, 0x30, 0x00,
                0x31, 0x00, 0x30, 0x00, 0x30, 0x00, 0x2D, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x7D, 0x00, 0x00, 0x00, 0x0D, 0x00, 0x00, 0x00,
                0x03, 0xD5, 0x15, 0x0C, 0x17, 0xD0, 0xCE, 0x47,
                0x90, 0x16, 0x7B, 0x3F, 0x97, 0x87, 0x21, 0xCC,
                0x08, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x6B, 0xEF,
                0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC, 0xDA, 0x8B,
                0x60, 0xEE, 0x4A, 0x3C, 0x02, 0x00, 0x00, 0x00,
                0x1F, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00,
                0x6F, 0x00, 0x31, 0x00, 0x00, 0x00, 0x0D, 0x49,
                0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC,
                0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C, 0x12, 0x00,
                0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0xAA, 0xCB,
                0xED, 0xCF, 0x3D, 0xAE, 0xE4, 0x40, 0x0D, 0x49,
                0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC,
                0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C, 0x13, 0x00,
                0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0xAA, 0xCB,
                0xED, 0xCF, 0x3D, 0xAE, 0xE4, 0x40, 0x0D, 0x49,
                0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC,
                0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C, 0x06, 0x00,
                0x00, 0x00, 0x48, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x01, 0x30, 0x6C, 0xAE, 0x04, 0x48, 0x98, 0xBA,
                0xC5, 0x7B, 0x46, 0x96, 0x5F, 0xE7, 0x0D, 0x49,
                0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC,
                0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C, 0x07, 0x00,
                0x00, 0x00, 0x48, 0x00, 0x00, 0x00, 0x92, 0xE3,
                0xE2, 0x27, 0x11, 0xA1, 0xE0, 0x48, 0xAB, 0x0C,
                0xE1, 0x77, 0x05, 0xA0, 0x5F, 0x85, 0x0D, 0x49,
                0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43, 0xAF, 0xFC,
                0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C, 0x17, 0x00,
                0x00, 0x00, 0x1F, 0x00, 0x00, 0x00, 0x0E, 0x00,
                0x00, 0x00, 0x73, 0x00, 0x31, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x31, 0x00, 0x00, 0x00,
                0x0D, 0x49, 0x6B, 0xEF, 0xD8, 0x5C, 0x7A, 0x43,
                0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C,
                0x05, 0x00, 0x00, 0x00, 0x1F, 0x00, 0x00, 0x00,
                0x4E, 0x00, 0x00, 0x00, 0x7B, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x31, 0x00, 0x2D, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x2D, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x2D, 0x00, 0x30, 0x00, 0x31, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x2D, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x30, 0x00,
                0x30, 0x00, 0x30, 0x00, 0x30, 0x00, 0x7D, 0x00,
                0x00, 0x00, 0x0D, 0x49, 0x6B, 0xEF, 0xD8, 0x5C,
                0x7A, 0x43, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE,
                0x4A, 0x3C, 0x0C, 0x00, 0x00, 0x00, 0x1F, 0x00,
                0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x44, 0x00,
                0x43, 0x00, 0x49, 0x00, 0x4D, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00
            };

            MtpFileEntryShellItem item = new MtpFileEntryShellItem(buf);

            Assert.IsTrue(item.Fields.Count == 9);

            Assert.IsTrue(item.Fields.ContainsKey("Size"));
            Assert.IsTrue(item.Fields.ContainsKey("Signature"));
            Assert.IsTrue(item.Fields.ContainsKey("TypeName"));
            Assert.IsTrue(item.Fields.ContainsKey("SubtypeName"));
            Assert.IsTrue(item.Fields.ContainsKey("ModifiedDate"));
            Assert.IsTrue(item.Fields.ContainsKey("CreationDate"));
            Assert.IsTrue(item.Fields.ContainsKey("FolderName"));
            Assert.IsTrue(item.Fields.ContainsKey("FolderId"));
            Assert.IsTrue(item.Fields.ContainsKey("Description"));

            Assert.IsTrue(item.Fields["Size"] as ushort? == item.Size);
            Assert.IsTrue(item.Fields["Signature"] as uint? == item.Signature);
            Assert.IsTrue(item.Fields["TypeName"] as string == item.TypeName);
            Assert.IsTrue(item.Fields["SubtypeName"] as string == item.SubtypeName);
            Assert.IsTrue(item.Fields["ModifiedDate"] as DateTime? == item.ModifiedDate);
            Assert.IsTrue(item.Fields["CreationDate"] as DateTime? == item.CreationDate);
            Assert.IsTrue(item.Fields["FolderName"] as string == item.FolderName);
            Assert.IsTrue(item.Fields["FolderId"] as string == item.FolderId);
            Assert.IsTrue(item.Fields["Description"] as string == item.Description);

            Assert.IsTrue(item.Size == 554);
            Assert.IsTrue(item.Signature == 0x07192006);
            Assert.IsTrue(item.TypeName == "Media Transfer Protocol");
            Assert.IsTrue(item.SubtypeName == "File Entry");
            Assert.IsTrue(item.ModifiedDate == new DateTime(0x08d3059e16829480));
            Assert.IsTrue(item.CreationDate == new DateTime(0x08d3059e16829480));
            Assert.IsTrue(item.FolderName == "DCIM");
            Assert.IsTrue(item.FolderId == "{00000001-0000-0000-0100-000000000000}");
            Assert.IsTrue(item.Description == item.FolderName);
        }
    }
}