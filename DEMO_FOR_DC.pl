start:-
    reason(Problem),
    write('Toi doan may tinh ban bi '),
    write(Problem),
    nl,
    undo.
/* reason that should be tested*/
reason(long_day_nguon):- long_day_nguon,!.
reason(bo_nguon_hong):- bo_nguon_hong,!.
reason(loi_bo_mach_chu):- loi_bo_mach_chu,!.
reason(long_o_cung):- long_o_cung,!.
reason(o_cung_hong_hoac_bi_bad):- o_cung_hong_hoac_bi_bad,!.
reason(os_error):- os_error,!.
reason(unknown). /*no diagnosis*/

/*reason Identification Rules*/
long_day_nguon:-
    verify(long_day_nguon),
    verify(den_nguon_tat_quat_khong_chay),
    write('De nghi kiem tra day nguon'),
    nl.
bo_nguon_hong:-
    not(verify(long_day_nguon)),
    verify(den_nguon_tat_quat_khong_chay),
    write('Bo nguon hong, hay di thay nguon'),
    nl.
loi_bo_mach_chu:-
    verify(quat_quay_nhung_khong_len_hinh),
    verify(den_nguon_sang_co_tieng_bip),
    write('Loi bo mach chu, nen cai lai driver'),
    nl.
long_o_cung:-
    verify(long_o_cung),
    verify(den_o_cung_khong_doc),
    verify(den_nguon_sang_nhung_khong_nhan_os),
    write('long_o_cung'),
    nl.
o_cung_hong_hoac_bi_bad:-
    not(verify(long_o_cung)),
    verify(den_o_cung_khong_doc),
    verify(den_nguon_sang_nhung_khong_nhan_os),
    write('o cung hong hoac bi bad'),
    nl.
os_error:-
    verify(den_o_cung_doc),
    verify(den_nguon_sang_nhung_khong_nhan_os),
    write('he dieu hanh loi, de nghi cai lai os'),
    nl.
/* how  to ask question*/
ask(Question):-
    write('May tinh ban co bi: '),
    write(Question),
    write('? '),
    read(Response),
    nl,
    ( (Response == yes ; Response == y)
    ->
    assert(yes(Question));
    assert(no(Question)), fail).
:- dynamic yes/1,no/1.
verify(S):-
    (yes(S) -> true;
    (no(S) -> fail; ask(S))).
undo:- retract(yes(_)),fail.
undo:- retract(no(_)),fail.
undo.
