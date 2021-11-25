import { Component, OnInit } from '@angular/core';
import { FormaPagamento } from 'src/app/models/forma-pagamento';
import { FormaPagamentoService } from 'src/app/services/forma-pagemento.service';

@Component({
  selector: 'app-finalizar',
  templateUrl: './finalizar.component.html',
  styleUrls: ['./finalizar.component.css']
})
export class FinalizarComponent implements OnInit {

  nome!: string;
  formaPagamento!: FormaPagamento;
  formasDePagamentos: FormaPagamento[] = [];

  constructor(private serviceForma: FormaPagamentoService) { }

  ngOnInit(): void {
    this.serviceForma.list().subscribe((formas) => {
        this.formasDePagamentos = formas;
    });
  }

  cadastrarVenda(): void {
    console.log("teste")
  }
}
