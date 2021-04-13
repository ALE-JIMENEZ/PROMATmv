using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promat.WAPI.Shared
{
    public interface iActividad_Solicitud
    {
        decimal Act_Padre { get; set; }
        decimal Centro_Gestion { get; set; }
        decimal Costo_Estimado { get; set; }
        string Descripcion { get; set; }
        decimal Id_Actividad { get; set; }
        decimal Tiempo_Estimado { get; set; }
        int Tiempo_Habil { get; set; }
        string Tipo_Tiempo { get; set; }
    }

    public interface iCentro_Costo
    {
        decimal Centro_Gestion { get; set; }
        string Codigo { get; set; }
        string Descripcion { get; set; }
    }

    public interface iSolicitud
    {
        decimal actividad_solicitud_0 { get; set; }
        decimal actividad_solicitud_1 { get; set; }
        decimal aprobado_por { get; set; }
        decimal area_trabajo { get; set; }
        decimal asignado_a { get; set; }
        decimal centro_gestion { get; set; }
        decimal centro_gestion_ejecuta { get; set; }
        int cer_estado { get; set; }
        string codigo_equipo { get; set; }
        decimal compania { get; set; }
        decimal departamento { get; set; }
        decimal familia_equipo { get; set; }
        DateTime fec_requerido_trabajo { get; set; }
        DateTime fecha_reporte { get; set; }
        decimal grupo_equipo { get; set; }
        string id_solicitud { get; set; }
        decimal linea { get; set; }
        string numero_inspeccion { get; set; }
        string observaciones_otros { get; set; }
        decimal oficina { get; set; }
        decimal orden_trabajo { get; set; }
        string pais { get; set; }
        decimal prioridad { get; set; }
        string que_reporta { get; set; }
        decimal seccion { get; set; }
        string solicitado_por { get; set; }
        decimal tiempo_inspeccion { get; set; }
        decimal unidad_ejecutora { get; set; }
    }

    public interface iCompania
    {
        string descripcion { get; set; }
        decimal id_codigo { get; set; }
        decimal linea { get; set; }
        string pais { get; set; }
    }

    public interface iConfiguracion
    {
        decimal Idioma_Default { get; set; }
        string Pais { get; set; }
        string Websol_Cod_Equipo_Gen { get; set; }
        int Websol_Fec_Auto { get; set; }
        int Websol_Manuals_Equiv { get; set; }
        int Websol_Perm_Rechazo_Vb { get; set; }
        int Websol_Qs_Auto { get; set; }
        int Websol_Sol_Usa_Cia { get; set; }
        int Websol_Sol_Usa_Linea { get; set; }
        int Websol_Todos_Equ { get; set; }
        int Websol_Ubic_Compl { get; set; }
        int Websol_Usa_Equipo_Gen { get; set; }
    }

    public interface iDepartamento
    {
        decimal Compania { get; set; }
        decimal Id_Codigo { get; set; }
        decimal Linea { get; set; }
        string Pais { get; set; }
    }

    public interface iFichas
    {
        decimal Centro_Gestion { get; set; }
        string Codigo_Equipo { get; set; }
        decimal Compania { get; set; }
        decimal Departamento { get; set; }
        string Descripcion { get; set; }
        decimal Linea { get; set; }
        decimal Oficina { get; set; }
        string Pais { get; set; }
        decimal Seccion { get; set; }
    }

    public interface iLinea
    {
        string Descripcion { get; set; }
        decimal Id_Codigo { get; set; }
        string Pais { get; set; }
    }

    public interface iOficinas
    {
        decimal Compania { get; set; }
        decimal Departamento { get; set; }
        string Descripcion { get; set; }
        decimal Id_Codigo { get; set; }
        decimal Linea { get; set; }
        string Pais { get; set; }
    }

    public interface iOperador
    {
        string Cedula { get; set; }
        decimal Centro_Gestion { get; set; }
        decimal Compania { get; set; }
        string Contrasena { get; set; }
        decimal Departamento { get; set; }
        string Descripcion { get; set; }
        string Email { get; set; }
        decimal Id_Operador { get; set; }
        decimal Linea { get; set; }
        string Login { get; set; }
        decimal Oficina { get; set; }
        string Pais { get; set; }
        decimal Seccion { get; set; }
        DateTime? Ult_Act_Contra { get; set; }
    }

    public interface iSecciones
    {
        decimal Compania { get; set; }
        decimal Departamento { get; set; }
        string Descripcion { get; set; }
        decimal Id_Codigo { get; set; }
        decimal Linea { get; set; }
        decimal Oficina { get; set; }
        string Pais { get; set; }
    }

    public interface iWebSolicitud
    {
        decimal Actividad_Cat { get; set; }
        decimal Actividad_Sol { get; set; }
        string Adjunto_Sol { get; set; }
        decimal Area { get; set; }
        string Centro_Costo { get; set; }
        decimal Centro_Gestion { get; set; }
        string Codigo_Equipo { get; set; }
        decimal Compania { get; set; }
        decimal Departamento { get; set; }
        string Detalle_Solicitud { get; set; }
        string Estado { get; set; }
        DateTime? Fecha_Ingreso { get; set; }
        DateTime? Fecha_Registro { get; set; }
        DateTime? Fecha_Requerido { get; set; }
        decimal Id_Reg { get; set; }
        decimal Id_Usuario { get; set; }
        decimal Jefatura_Aut { get; set; }
        decimal Linea { get; set; }
        decimal Oficina { get; set; }
        string Pais { get; set; }
        string Quien_Reporta { get; set; }
        string Quien_Solicita { get; set; }
        decimal Seccion { get; set; }
        decimal Solicitud_Asignada { get; set; }
        decimal Tipo_Solicitud { get; set; }
        decimal Unidad { get; set; }
        int Vb_Ot_Acepta_Tep { get; set; }
        decimal Vb_Ot_Calificacion { get; set; }
        DateTime? Vb_Ot_Fecha_Aplica { get; set; }
        string Vb_Ot_Observaciones { get; set; }
    }

}
