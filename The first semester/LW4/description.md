# ������������ ������ 4: ������� ���������� ���������

��������: �������� ���� 408456 K3244
��������: 

## �������
������������ ������� ��� ���������� ��������� � �� ������� � ���������� ����������.

������� ������:

1. ������������ �������� � ���������� ���������, ������� ���������� ��������� ����� ������ (��������, �������, ����������, ��������������).
2. ������������ ����������� �������� ������� ����� �������, ���������� ��������� � ������� ����� ��������.
3. �������� ������� ��� ��������� ������� �� ��������� �����, ������� �������� � ����� ���������� �� ��������.
4. ������������ ������ ������ (��� �������, �����, ����, ������) � �������� ���������� ���� �� ������� �������. ��������, �� API �� ��.   
5. ������ ���������� ������� unit �������
6. �� ���������� �������������� ������ ����� ��������� �������������� ����� 

**�� ��������� ��� �������� ��� �����, ������� ���������� ��������� ���������� ����������� ����������. ������� ������ ���� ��������.**

���� �� ����������� � ���������� ��������� ��� � ��������� �������������� ��� �������� ����������, �������������� � ����� �������������� ������� ���������� ��������� � ����������� �������.

## ���������� �������

### ������
������ ������� ����� (�������, ���������� ��� ��������������).
����� ����� ��������� ��������, ����� ��� ����������, ������ � ��������, ��� ���� ������ �������� ����������� � ������� ����������.
��� ��������� ����� ������� ��� ����������� ����� ������������ TransferService, ������� ��������� ������������� ������� � ��������� ����� ����� �� �������� �����.
��� ���������� � �������������� ������ ����� ��������� �������, ��������� InterestCalculator, ������� ��������� ���������� ������, ������������ ����� InterestRate.
��������� ������� ��������� ����������� ��������� ������, ������� �������� � ���������� �� ������� �������.

### ������ 

Client(���, �������� � ������ ������)

Account(������, ������, ������� ��������)(����������, ������, ���������)

CheckingAccount, DepositAccount, InvestmentAccount - ����������� Account

Transaction (�����, ����, ��� ��������, �����)(�������, ���������� ���������)

TransferService(�������� ������������� ������� � ��������� ������)

Currency (���, ��������, ����)

CurrencyConverter (�����������)

Report (������  �� ������ � �������� ��������)

InterestRate(���������� � ���������� �������) 

InterestCalculator (����������� �������� �� ����� ������)



