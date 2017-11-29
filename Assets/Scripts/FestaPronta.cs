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
using UnityEngine.Audio;

public class FestaPronta : MonoBehaviour {
	public AudioMixerSnapshot dentro;
	public AudioMixerSnapshot fora;
	public AudioMixer mixer;

	private AudioSource BGM;

	void Start() {
		BGM = GetComponentInChildren<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D outro) {
		if(outro.CompareTag("Player")) {
			dentro.TransitionTo(1f);
		}
	}

	void OnTriggerExit2D(Collider2D outro) {
		if(outro.CompareTag("Player")) {
			fora.TransitionTo(0.1f);
		}
	}

	public void OnVolumeSlider(float volume) {
		mixer.SetFloat("MusicVolume", volume);
	}

	public void TogglePausa(bool pausado) {
		if(pausado) {
			BGM.Pause();
		}
		else {
			BGM.UnPause();
		}
	}
}
