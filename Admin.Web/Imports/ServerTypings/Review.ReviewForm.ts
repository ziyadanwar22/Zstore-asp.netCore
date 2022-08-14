namespace Admin.Review {
    export interface ReviewForm {
        Name: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Subject: Serenity.StringEditor;
        Descriptin: Serenity.StringEditor;
    }

    export class ReviewForm extends Serenity.PrefixedContext {
        static formKey = 'Review.Review';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ReviewForm.init)  {
                ReviewForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ReviewForm, [
                    'Name', w0,
                    'Email', w0,
                    'Subject', w0,
                    'Descriptin', w0
                ]);
            }
        }
    }
}
