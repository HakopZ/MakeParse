﻿using Excersize;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ParseTreeProject
{
    public class ProductionGroup : IEnumerable<Production>
    {
        public string ID { get; set; }

        public List<Production> productions { get; set; }
        public ProductionGroup(string id)
        { 
           ID = id;
           productions = new List<Production>();
        }
        public void Add(Production p)
        {
            productions.Add(p);
        }
        public IEnumerator<Production> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
