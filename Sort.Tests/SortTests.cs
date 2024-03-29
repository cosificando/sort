using System;
using System.Collections.Generic;
using Xunit;

namespace Sort.Tests
{
    public class SortTests
    {
        // Ordenar una Matrix vac�a
        [Fact]
        public void OrdenamosUnaListaVaciaElResultadoEsUnaListaVacia()
        {

            List<int> list = new List<int>();
            List<int> sortList = Sort.asList(list);
            
            Assert.True(list.Count == 0);
            Assert.True(sortList.Count == 0);
        }
        // La ordenaci�n de una Lista con un elemento es la misma lista con un elemento
        [Fact]
        public void OrdenadomosUnaListaConUnElementoEsLaMismaListaConUnElemento()
        {
            List<int> list = new List<int>();
            
            list.Add(1);
            List<int> sortList = Sort.asList(list);
           
            Assert.Equal(list, Sort.asList(list));
        }

        [Fact]
        public void PasamosDosElementosOrdenadosYNosLosDevuelveOrdenados()
        {
        
          //  Assert.Equal(List<int>()[1][2],)
        }
    }
}
