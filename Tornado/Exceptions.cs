using System;
using System.Collections.Generic;
using System.Text;

namespace Tornado
{

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un pedido.-
    /// </summary>
    public class PedidoNoEncontradoException : Exception
    {
        public PedidoNoEncontradoException()
            : base("No se ha podido encontrar el pedido.-")
        {
        }

        public PedidoNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public PedidoNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra un pedido con datos no válidos.-
    /// </summary>
    public class PedidoNoValidoException : Exception
    {
        public PedidoNoValidoException()
            : base("El pedido buscado contiene datos no válidos.-")
        {
        }

        public PedidoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public PedidoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se puede actualizar un pedido.-
    /// </summary>
    public class PedidoNoActualizadoException : Exception
    {
        public PedidoNoActualizadoException()
            : base("No se ha podido actualizar el pedido.")
        {
        }

        public PedidoNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public PedidoNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }


    #region AUDITORIAS

    /// <summary>
    /// Excepción que se produce cuando no se puede crear una auditoría.-
    /// </summary>
    public class AuditoriaNoCreadaException : Exception
    {
        public AuditoriaNoCreadaException()
            : base("No se ha podido crear la auditoría.-")
        {
        }

        public AuditoriaNoCreadaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoCreadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar una auditoría buscada.-
    /// </summary>
    public class AuditoriaNoEncontradaException : Exception
    {
        public AuditoriaNoEncontradaException()
            : base("No se ha podido encontrar la auditoría especificada.-")
        {
        }

        public AuditoriaNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra una auditoría con datos no válidos.-
    /// </summary>
    public class AuditoriaNoValidaException : Exception
    {
        public AuditoriaNoValidaException()
            : base("La auditoría tiene datos no válidos.-")
        {
        }

        public AuditoriaNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion


    #region EXCEPCIONES_GENERICAS

    /// <summary>
    /// Excepción que produce cuando se detecta un id no válido.-
    /// </summary>
    public class IdNoValidoException : Exception
    {
        public IdNoValidoException()
            : base("El id informado no es válido.-")
        {
        }

        public IdNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public IdNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta un código no válido.-
    /// </summary>
    public class CodigoNoValidoException : Exception
    {
        public CodigoNoValidoException()
            : base("El código informado no es válido.-")
        {
        }

        public CodigoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta un nombre duplicado.-
    /// </summary>
    public class NombreRepetidoException: Exception
    {
        public NombreRepetidoException()
            : base("El nombre informado ya existe.-")
        {
        }

        public NombreRepetidoException(string mensaje)
            : base(mensaje)
        {
        }

        public NombreRepetidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta una descripción vacía.-
    /// </summary>
    public class DescripcionVaciaException : Exception
    {
        public DescripcionVaciaException()
            : base("La descripción recibida está vacía.-")
        {
        }

        public DescripcionVaciaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionVaciaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una descripción cuya longitud que supera el máximo estipulado.-
    /// </summary>
    public class DescripcionMuyLargaException : Exception
    {
        public DescripcionMuyLargaException()
            : base("La descripción recibida supera la longitud máxima establecida.-")
        {
        }

        public DescripcionMuyLargaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionMuyLargaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una descripción repetida.-
    /// </summary>
    public class DescripcionRepetidaException : Exception
    {
        public DescripcionRepetidaException()
            : base("La descripción recibida se encuentra repetida.-")
        {
        }

        public DescripcionRepetidaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionRepetidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una opción no válida.-
    /// </summary>
    public class OpcionNoValidaException : Exception
    {
        public OpcionNoValidaException()
            : base("La opción especificada no es válida.-")
        {
        }

        public OpcionNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public OpcionNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta una descripción vacía.-
    /// </summary>
    public class IntervaloNoEncontradoException : Exception
    {
        public IntervaloNoEncontradoException()
            : base("No se ha encontrado un intervalo con el Id especificado.-")
        {
        }

        public IntervaloNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public IntervaloNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion



#region EXCEPCIONES_Parametros

    /// <summary>
    /// Excepción que se produce cuando la parametrización encontrada no es válida.-
    /// </summary>
    public class ParametrizacionNoValidaException : Exception
    {
        public ParametrizacionNoValidaException()
            : base("La parametrización del sistema tiene datos no válidos.-")
        {
        }

        public ParametrizacionNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametrizacionNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar la parametrización.-
    /// </summary>
    public class ParametrizacionNoEncontradaException : Exception
    {
        public ParametrizacionNoEncontradaException()
            : base("No se ha podido encontrar la parametrización del sistema.-")
        {
        }

        public ParametrizacionNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametrizacionNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede realizar la actualización de un parámetro.-
    /// </summary>
    public class ParametroNoActualizadoException : Exception
    {
        public ParametroNoActualizadoException()
            : base("No se ha podido actualizar el parámetro.-")
        {
        }

        public ParametroNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametroNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion

}
