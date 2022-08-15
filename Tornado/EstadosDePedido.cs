
namespace Tornado
{ 
	/// <summary>
	/// Lista los diferentes estados que puede tener un pedido.-
	/// </summary>
	public enum EstadosDePedido : int 
	{
		/// <summary>
		/// Pedido Pendiente de Procesar
		/// </summary>
		Pendiente = 9,

		/// <summary>
		/// Pedido en Proceso
		/// </summary>
		EnProceso = 2,

		/// <summary>
		/// Pedido Procesado
		/// </summary>
		Procesado = 1
	}
}