word.GroupBy(w => w)
                            .Max(grp => grp.Count());