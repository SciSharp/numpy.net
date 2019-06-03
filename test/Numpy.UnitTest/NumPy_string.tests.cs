// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Python.Included;
using Numpy.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPy_stringTest : BaseTestCase
    {
        
        [TestMethod]
        public void capitalizeTest()
        {
            // >>> c = np.array(['a1b2','1b2a','b2a1','2a1b'],'S4'); c
            // array(['a1b2', '1b2a', 'b2a1', '2a1b'],
            //     dtype='|S4')
            // >>> np.char.capitalize(c)
            // array(['A1b2', '1b2a', 'B2a1', '2a1b'],
            //     dtype='|S4')
            // 
            
            #if TODO
            var given=  c = np.array({'a1b2','1b2a','b2a1','2a1b'},'S4'); c;
            var expected=
                "array(['a1b2', '1b2a', 'b2a1', '2a1b'],\n" +
                "    dtype='|S4')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.capitalize(c);
             expected=
                "array(['A1b2', '1b2a', 'B2a1', '2a1b'],\n" +
                "    dtype='|S4')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void decodeTest()
        {
            // >>> c = np.array(['aAaAaA', '  aA  ', 'abBABba'])
            // >>> c
            // array(['aAaAaA', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // >>> np.char.encode(c, encoding='cp037')
            // array(['\x81\xc1\x81\xc1\x81\xc1', '@@\x81\xc1@@',
            //     '\x81\x82\xc2\xc1\xc2\x82\x81'],
            //     dtype='|S7')
            // 
            
            #if TODO
            var given=  c = np.array({'aAaAaA', '  aA  ', 'abBABba'});
             given=  c;
            var expected=
                "array(['aAaAaA', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.encode(c, encoding='cp037');
             expected=
                "array(['\x81\xc1\x81\xc1\x81\xc1', '@@\x81\xc1@@',\n" +
                "    '\x81\x82\xc2\xc1\xc2\x82\x81'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void lowerTest()
        {
            // >>> c = np.array(['A1B C', '1BCA', 'BCA1']); c
            // array(['A1B C', '1BCA', 'BCA1'],
            //       dtype='|S5')
            // >>> np.char.lower(c)
            // array(['a1b c', '1bca', 'bca1'],
            //       dtype='|S5')
            // 
            
            #if TODO
            var given=  c = np.array({'A1B C', '1BCA', 'BCA1'}); c;
            var expected=
                "array(['A1B C', '1BCA', 'BCA1'],\n" +
                "      dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.lower(c);
             expected=
                "array(['a1b c', '1bca', 'bca1'],\n" +
                "      dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void lstripTest()
        {
            // >>> c = np.array(['aAaAaA', '  aA  ', 'abBABba'])
            // >>> c
            // array(['aAaAaA', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // 
            
            #if TODO
            var given=  c = np.array({'aAaAaA', '  aA  ', 'abBABba'});
             given=  c;
            var expected=
                "array(['aAaAaA', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // The ‘a’ variable is unstripped from c[1] because whitespace leading.
            
            // >>> np.char.lstrip(c, 'a')
            // array(['AaAaA', '  aA  ', 'bBABba'],
            //     dtype='|S7')
            // 
            
            #if TODO
             given=  np.char.lstrip(c, 'a');
             expected=
                "array(['AaAaA', '  aA  ', 'bBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.char.lstrip(c, 'A') # leaves c unchanged
            // array(['aAaAaA', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // >>> (np.char.lstrip(c, ' ') == np.char.lstrip(c, '')).all()
            // ... # XXX: is this a regression? this line now returns False
            // ... # np.char.lstrip(c,'') does not modify c at all.
            // True
            // >>> (np.char.lstrip(c, ' ') == np.char.lstrip(c, None)).all()
            // True
            // 
            
            #if TODO
             given=  np.char.lstrip(c, 'A') # leaves c unchanged;
             expected=
                "array(['aAaAaA', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  (np.char.lstrip(c, ' ') == np.char.lstrip(c, '')).all();
             expected=
                "... # XXX: is this a regression? this line now returns False\n" +
                "... # np.char.lstrip(c,'') does not modify c at all.\n" +
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  (np.char.lstrip(c, ' ') == np.char.lstrip(c, None)).all();
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void rstripTest()
        {
            // >>> c = np.array(['aAaAaA', 'abBABba'], dtype='S7'); c
            // array(['aAaAaA', 'abBABba'],
            //     dtype='|S7')
            // >>> np.char.rstrip(c, 'a')
            // array(['aAaAaA', 'abBABb'],
            //     dtype='|S7')
            // >>> np.char.rstrip(c, 'A')
            // array(['aAaAa', 'abBABba'],
            //     dtype='|S7')
            // 
            
            #if TODO
            var given=  c = np.array({'aAaAaA', 'abBABba'}, dtype='S7'); c;
            var expected=
                "array(['aAaAaA', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.rstrip(c, 'a');
             expected=
                "array(['aAaAaA', 'abBABb'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.rstrip(c, 'A');
             expected=
                "array(['aAaAa', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void stripTest()
        {
            // >>> c = np.array(['aAaAaA', '  aA  ', 'abBABba'])
            // >>> c
            // array(['aAaAaA', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // >>> np.char.strip(c)
            // array(['aAaAaA', 'aA', 'abBABba'],
            //     dtype='|S7')
            // >>> np.char.strip(c, 'a') # 'a' unstripped from c[1] because whitespace leads
            // array(['AaAaA', '  aA  ', 'bBABb'],
            //     dtype='|S7')
            // >>> np.char.strip(c, 'A') # 'A' unstripped from c[1] because (unprinted) ws trails
            // array(['aAaAa', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // 
            
            #if TODO
            var given=  c = np.array({'aAaAaA', '  aA  ', 'abBABba'});
             given=  c;
            var expected=
                "array(['aAaAaA', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.strip(c);
             expected=
                "array(['aAaAaA', 'aA', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.strip(c, 'a') # 'a' unstripped from c{1} because whitespace leads;
             expected=
                "array(['AaAaA', '  aA  ', 'bBABb'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.strip(c, 'A') # 'A' unstripped from c{1} because (unprinted) ws trails;
             expected=
                "array(['aAaAa', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void swapcaseTest()
        {
            // >>> c=np.array(['a1B c','1b Ca','b Ca1','cA1b'],'S5'); c
            // array(['a1B c', '1b Ca', 'b Ca1', 'cA1b'],
            //     dtype='|S5')
            // >>> np.char.swapcase(c)
            // array(['A1b C', '1B cA', 'B cA1', 'Ca1B'],
            //     dtype='|S5')
            // 
            
            #if TODO
            var given=  c=np.array({'a1B c','1b Ca','b Ca1','cA1b'},'S5'); c;
            var expected=
                "array(['a1B c', '1b Ca', 'b Ca1', 'cA1b'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.swapcase(c);
             expected=
                "array(['A1b C', '1B cA', 'B cA1', 'Ca1B'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void titleTest()
        {
            // >>> c=np.array(['a1b c','1b ca','b ca1','ca1b'],'S5'); c
            // array(['a1b c', '1b ca', 'b ca1', 'ca1b'],
            //     dtype='|S5')
            // >>> np.char.title(c)
            // array(['A1B C', '1B Ca', 'B Ca1', 'Ca1B'],
            //     dtype='|S5')
            // 
            
            #if TODO
            var given=  c=np.array({'a1b c','1b ca','b ca1','ca1b'},'S5'); c;
            var expected=
                "array(['a1b c', '1b ca', 'b ca1', 'ca1b'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.title(c);
             expected=
                "array(['A1B C', '1B Ca', 'B Ca1', 'Ca1B'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void upperTest()
        {
            // >>> c = np.array(['a1b c', '1bca', 'bca1']); c
            // array(['a1b c', '1bca', 'bca1'],
            //     dtype='|S5')
            // >>> np.char.upper(c)
            // array(['A1B C', '1BCA', 'BCA1'],
            //     dtype='|S5')
            // 
            
            #if TODO
            var given=  c = np.array({'a1b c', '1bca', 'bca1'}); c;
            var expected=
                "array(['a1b c', '1bca', 'bca1'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.upper(c);
             expected=
                "array(['A1B C', '1BCA', 'BCA1'],\n" +
                "    dtype='|S5')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void countTest()
        {
            // >>> c = np.array(['aAaAaA', '  aA  ', 'abBABba'])
            // >>> c
            // array(['aAaAaA', '  aA  ', 'abBABba'],
            //     dtype='|S7')
            // >>> np.char.count(c, 'A')
            // array([3, 1, 1])
            // >>> np.char.count(c, 'aA')
            // array([3, 1, 0])
            // >>> np.char.count(c, 'A', start=1, end=4)
            // array([2, 1, 1])
            // >>> np.char.count(c, 'A', start=1, end=3)
            // array([1, 0, 0])
            // 
            
            #if TODO
            var given=  c = np.array({'aAaAaA', '  aA  ', 'abBABba'});
             given=  c;
            var expected=
                "array(['aAaAaA', '  aA  ', 'abBABba'],\n" +
                "    dtype='|S7')";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.count(c, 'A');
             expected=
                "array([3, 1, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.count(c, 'aA');
             expected=
                "array([3, 1, 0])";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.count(c, 'A', start=1, end=4);
             expected=
                "array([2, 1, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  np.char.count(c, 'A', start=1, end=3);
             expected=
                "array([1, 0, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
    }
}