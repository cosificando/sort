using System;
using System.Collections.Generic;
using Xunit;

namespace Sort.Tests
{
    public class SortTests
    {
        // Ordenar una Matrix vacía
        [Fact]
        public void OrdenamosUnaListaVaciaElResultadoEsUnaListaVacia()
        {

            List<int> list = new List<int>();
            List<int> sortList = Sort.asList(list);
            
            Assert.True(list.Count == 0);
            Assert.True(sortList.Count == 0);
        }
        // La ordenación de una Lista con un elemento es la misma lista con un elemento
        [Fact]
        public void OrdenadomosUnaListaConUnElementoEsLaMismaListaConUnElemento()
        {
            List<int> list = new List<int>();
            list.Add(1);
            List<int> sortList = Sort.asList(list);
            Assert.True(list.Count == 1);
            Assert.True(sortList.Count == 1);
            Assert.True(list.ToArray().GetValue(0) == sortList.ToArray().GetValue(0));

        }
    }
}
