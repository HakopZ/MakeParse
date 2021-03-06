﻿using Excersize;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParserProject
{
    public class ParseTreeNode
    {
        public Token Value { get; set; }
        public List<ParseTreeNode> Children;
        public List<Token> Expression;
        
        public bool IsTerminal { get; set; }

        public ParseTreeNode(Token val, bool isT)
        {
            Expression = new List<Token>();
            Children = new List<ParseTreeNode>();
            Value = val;
            IsTerminal = isT;
        }
        public void Add(ParseTreeNode node)
        {
            Children.Add(node);
        }
        public void AddRange(IEnumerable<ParseTreeNode> nodes)
        {
            foreach(var node in nodes)
            {
                Children.Add(node);
            }
        }
        public void AddExpression(Token node)
        {
            Expression.Add(node);
        }
        public void Print(string indent, bool last)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("\\:");
                indent += "  ";
            }
            else
            {
                Console.Write("\\:");
                indent += "\\ ";
            }

            Console.WriteLine(Value.Lexeme);

            for (int i = 0; i < Children.Count; i++)
                Children[i].Print(indent, i == Children.Count - 1);
        }
    }
}
