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

public class Luz : MonoBehaviour {
	public Color corForte;
	public Color corFade;

	private SpriteRenderer renderer;
	private float segundosFade;
	private float offset;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
		segundosFade = Random.Range(0.7f, 1.5f);
		offset = Random.Range(0f, segundosFade);
	}
	
	// Update is called once per frame
	void Update () {
		renderer.color = Color.Lerp(corForte, corFade, Mathf.PingPong(Time.time + offset, segundosFade) / segundosFade);
	}
}
