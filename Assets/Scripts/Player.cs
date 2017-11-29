/* Unity Audio Teste é um software livre; você pode redistribuí-lo e/ou 
 * modificá-lo sob os termos da Licença Pública Geral GNU como publicada
 * pela Fundação do Software Livre (FSF); na versão 3 da Licença,
 * ou (a seu critério) qualquer versão posterior.
 * 
 * Unity Audio Teste é distribuído na esperança de que possa ser útil, 
 * mas SEM NENHUMA GARANTIA; sem uma garantia implícita de ADEQUAÇÃO
 * a qualquer MERCADO ou APLICAÇÃO EM PARTICULAR. Veja a
 * Licença Pública Geral GNU para mais detalhes.
 * 
 * Você deve ter recebido uma cópia da Licença Pública Geral GNU junto
 * com Unity Audio Teste. Se não, veja <http://www.gnu.org/licenses/>.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float velocidade = 3f;

	void FixedUpdate () {
		var movePra = new Vector3();
		movePra.x = Input.GetAxis("Horizontal");
		movePra.y = Input.GetAxis("Vertical");
		transform.Translate(movePra.normalized * Time.fixedDeltaTime * velocidade);
	}
}
