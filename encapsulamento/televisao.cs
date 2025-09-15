public class Televisao
{
    private const int VOL_MIN = 0;
    private const int VOL_MAX = 100;
    private const int CANAL_MIN = 1;
    private const int CANAL_MAX = 520;

    private int _canalUltimoAssistido;
    private bool _mudoAtivado;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Estado = false;
        Volume = 50; // volume inicial padrão
        Canal = CANAL_MIN; // canal inicial
        _canalUltimoAssistido = Canal;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }

    // === Controle de Ligar / Desligar ===
    public void Ligar()
    {
        Estado = true;
        Canal = _canalUltimoAssistido; // volta para o último canal
    }

    public void Desligar()
    {
        Estado = false;
        _canalUltimoAssistido = Canal; // salva o último canal assistido
    }

    // === Controle de Volume ===
    public void AumentarVolume()
    {
        if (!_mudoAtivado && Volume < VOL_MAX)
            Volume++;
    }

    public void DiminuirVolume()
    {
        if (!_mudoAtivado && Volume > VOL_MIN)
            Volume--;
    }

    public void AtivarMudo()
    {
        _mudoAtivado = true;
    }

    public void DesativarMudo()
    {
        _mudoAtivado = false;
    }

    // === Controle de Canal ===
    public void AvancarCanal()
    {
        if (Canal < CANAL_MAX)
            Canal++;
    }

    public void VoltarCanal()
    {
        if (Canal > CANAL_MIN)
            Canal--;
    }

    public void IrParaCanal(int numero)
    {
        if (numero >= CANAL_MIN && numero <= CANAL_MAX)
            Canal = numero;
    }
}
