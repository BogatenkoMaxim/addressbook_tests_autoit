using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
            app.Groups.ChekingGroups();

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(1);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Remove(oldGroups[1]);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
