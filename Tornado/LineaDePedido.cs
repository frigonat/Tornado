﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinidad.Auditoria;
using TrinidadDb;


namespace Tornado
{
    /// <summary>
    /// Modela una línea de un pedido de St.Jude.-
    /// </summary>
    public class LineaDePedido
    {
        #region atributos
        /// <summary>
        /// Número de línea.-
        /// </summary>
        private int numero;
        
        /// <summary>
        /// Código del SKU de la línea.-
        /// </summary>
        private string codigoSKU;
        
        /// <summary>
        /// Cantidad de unidades de la línea.-
        /// </summary>
        private decimal cantidad;
        
        /// <summary>
        /// Unidad de medida de la línea.-
        /// </summary>
        private string unidadMedida;
        
        /// <summary>
        /// Número de lote.-
        /// </summary>
        private string loteCliente;
        
        /// <summary>
        /// Número de lote SAP del artículo.-
        /// </summary>
        private string loteSAP;
        
        /// <summary>
        /// Fecha de vencmiento del lote.-
        /// </summary>
        private DateTime fechaVencimiento;
        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número de la línea del pedido.-
        /// </summary>
        public int Numero
        {
            get { return this.numero; }
        }

        /// <summary>
        /// Obtiene el número del SKU en la línea.-
        /// </summary>
        public string CodigoSKU
        {
            get { return this.codigoSKU; }
        }

        /// <summary>
        /// Obtiene la cantidad de unidades en la línea.-
        /// </summary>
        public decimal Cantidad
        {
            get { return this.cantidad; }    
        }

        /// <summary>
        /// Obtiene la unidad de medida en la línea.-
        /// </summary>
        public string UnidadMedida
        {
            get { return this.unidadMedida; }
        }

        /// <summary>
        /// Obtiene el número de lote del cliente para el producto en la línea.-
        /// </summary>
        public string LoteCliente
        {
            get { return this.loteCliente; }
        }
        /// <summary>
        /// Obtiene el número de lote SAP para el producto en la línea.-
        /// </summary>
        public string LoteSAP
        {
            get { return this.loteSAP; }
        }

        /// <summary>
        /// Obtiene la fecha de vencimiento del lote.-
        /// </summary>
        public DateTime FechaVencimiento 
        { 
            get { return this.fechaVencimiento; }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoNumero">Número de la línea del pedido.-</param>
        /// <param name="nuevoSKU">Código de SKU de línea del pedido.-</param>
        /// <param name="nuevaCantidad">Cantidad de unidades de la línea.-</param>
        /// <param name="nuevaUOM">Unidad de Medida.-</param>
        /// <param name="nuevoLoteCliente">Número de lote del cliente.-</param>
        /// <param name="nuevoLoteSAP">Número de lote SAP.-</param>
        /// <param name="nuevaFechaVencimiento">Fecha de vencimiento del lote.-</param>
        internal LineaDePedido(int nuevoNumero, string nuevoSKU, decimal nuevaCantidad, string nuevaUOM, string nuevoLoteCliente, string nuevoLoteSAP, DateTime nuevaFechaVencimiento)
        {
            this.numero = nuevoNumero;
            this.codigoSKU = nuevoSKU;
            this.cantidad = nuevaCantidad;
            this.unidadMedida = nuevaUOM;
            this.loteCliente = nuevoLoteCliente;    
            this.loteSAP = nuevoLoteSAP;
            this.fechaVencimiento = nuevaFechaVencimiento;
        }

    }
}
