namespace InfoCodFiscal;

using System;
using System.Collections.Generic;

public class FirmaInfo
{
    public object accize { get; set; }
    public object act_autorizare { get; set; }
    public string adresa { get; set; }
    public string cif { get; set; }
    public string cod_postal { get; set; }
    public string denumire { get; set; }
    public object fax { get; set; }
    public object impozit_micro { get; set; }
    public string impozit_profit { get; set; }
    public string judet { get; set; }
    public Meta meta { get; set; }
    public string numar_reg_com { get; set; }
    public bool radiata { get; set; }
    public string stare { get; set; }
    public string telefon { get; set; }
    public string tva { get; set; }
    public List<TvaLaIncasare> tva_la_incasare { get; set; }
    public string ultima_declaratie { get; set; }
    public string ultima_prelucrare { get; set; }
}

