
//Clase para el calculo de area y perimetro por puntos.

public class Figura {

/*

	INFO: CALCULAR AREA Y PERIMTRO DE UNA FIGURA, BASADA EN PUNTOS
	RESTRICCIONES: NO SE PERMITEN PUNTOS O COORDENADAS NEGATIVAS

	AGREGAR PRUEBAS UNITARIAS
	OJO PATRONES Y ESTANDARES

*/
	public int calcularArea (int BaseA, int BaseB, int AlturaA, int AlturaB) {

		
		if (( BaseA < 0) || ( BaseB < 0)) {

			return 0;
			
		} 
		else {
		
			int baseFigura = BaseB - BaseA;

			if (baseFigura < 0) {

				return 0;
			}
		}

	

	}

	public int calcularPerimetro () {

	}


}