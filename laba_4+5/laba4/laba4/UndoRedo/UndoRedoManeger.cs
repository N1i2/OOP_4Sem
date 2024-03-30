using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.UndoRedo
{
    class UndoRedoManeger
    {
        public UndoRedoManeger()
        {
        }

        public void addVersia(string name, string price, string dick, string quantity)
        {
            savePage.Add(new Inform(name, price, dick, quantity));

            indexNow++;
        }
        public void clearAllVersia()
        {
            indexNow = -1;
            savePage.Clear();
        }

        private static List<Inform> savePage = new List<Inform>();
        private static int indexNow { get; set; } = -1;


        public static Inform ShowNow()
        {
            if (savePage.Count == 0)
                return new Inform();
            return savePage[indexNow];
        }
        public static Inform Undo()
        {
            if (indexNow == savePage.Count - 1)
                return new Inform();

            return savePage[++indexNow];
        }
        public static Inform Redo()
        {
            if (indexNow == 0)
                return new Inform();

            return savePage[--indexNow];
        }
    }
}
