
start(Problem):-
    reason(Problem),
    write('I believe that the Computer have'),
    write(Problem),
    nl,
    undo.
/* reason that should be tested*/
reason(miss_adapter):- miss_adapter,!.
reason(broken_adapter):- broken_adapter,!.
reason(error_mainboard):- error_mainboard,!.
reason(loose_hard_drive):- loose_hard_drive,!.
reason(broken_hard_drive):- broken_hard_drive,!.
reason(error_os):- error_os,!.
reason(unknown). /*no diagnosis*/



/*reason Identification Rules*/
miss_adapter:-
    ask(loose_wire),
    not(ask(fan_on)),
    not(ask(led_on)),
    write('miss_adapter!'),
    nl.
broken_adapter:-
    not(ask(loose_wire)),
    not(ask(fan_on)),
    not(ask(led_on)),
    write('broken_adapter'),
    nl.
error_mainboard:-
    ask(black_screen),
    ask(fan_on),
    ask(long_beep),
    ask(led_on),
    write('error_mainboard'),
    nl.
loose_hard_drive:-
    ask(dirty_hard_drive),
    ask(led_hard_drive_off),
    ask(not_load_os),
    ask(led_on),
    write('loose_hard_drive'),
    nl.
broken_hard_drive:-
    not(ask(dirty_hard_drive)),
    ask(led_hard_drive_off),
    ask(not_load_os),
    ask(led_on),
    write('broken_hard_drive'),
    nl.
error_os:-
    not(ask(led_hard_drive_off)),
    ask(not_load_os),
    ask(led_on),
    write('error_os'),
    nl.
/* how  to ask question*/
ask(Question):-
    write('Dose the Computer have following symptom:'),
    write(Question),
    write('? '),
    % read(Response),
    nl,
    string_codes(Q, Question),
    open(Q,read,Str),
    read(Str,Response),
    write(Response),
    ( (Response == yes ; Response == y)
    ->
    assert(yes(Question));
    assert(no(Question)), fail).
:- dynamic yes/1,no/1.
%     write('Dose the Computer have following symptom:'),
%     write(Question),
%     write('? '),
%     read(Response),
%     nl,
%     ( (Response == yes ; Response == y)
%     ->
%     assert(yes(Question));
%     assert(no(Question)), fail).
% :- dynamic yes/1,no/1.

undo:- retract(yes(_)),fail.
undo:- retract(no(_)),fail.
undo.
